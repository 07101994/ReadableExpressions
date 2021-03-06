namespace AgileObjects.ReadableExpressions.Translators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extensions;
#if !NET35
    using System.Linq.Expressions;
#else
    using Expression = Microsoft.Scripting.Ast.Expression;
    using ExpressionType = Microsoft.Scripting.Ast.ExpressionType;
    using SwitchExpression = Microsoft.Scripting.Ast.SwitchExpression;
#endif
    using Formatting;

    internal struct SwitchExpressionTranslator : IExpressionTranslator
    {
        public IEnumerable<ExpressionType> NodeTypes
        {
            get { yield return ExpressionType.Switch; }
        }

        public string Translate(Expression expression, TranslationContext context)
        {
            var switchStatement = (SwitchExpression)expression;

            var switchValue = context.Translate(switchStatement.SwitchValue);

            var switchCases = switchStatement.Cases
                .Project(@case => new
                {
                    Tests = @case.TestValues.Project(value => $"case {context.Translate(value)}:"),
                    BodyBlock = context.TranslateCodeBlock(@case.Body)
                })
                .Project(@case => GetCase(@case.BodyBlock, @case.Tests.ToArray()));

            switchCases = AppendDefaultCaseIfExists(switchCases, switchStatement.DefaultBody, context);

            var switchCaseLines = switchCases.Join(Environment.NewLine + Environment.NewLine);

            var @switch = $@"
switch ({switchValue})
{{
{switchCaseLines}
}}";

            return @switch.TrimStart();
        }

        private static string GetCase(CodeBlock bodyBlock, params string[] labels)
        {
            if (!bodyBlock.HasReturn())
            {
                bodyBlock = bodyBlock.Append("break;");
            }

            var @case = bodyBlock.Indented().Insert(labels).Indented();

            return @case.WithoutCurlyBraces();
        }

        private IEnumerable<string> AppendDefaultCaseIfExists(
            IEnumerable<string> switchCases,
            Expression defaultBody,
            TranslationContext context)
        {
            foreach (var switchCase in switchCases)
            {
                yield return switchCase;
            }

            if (defaultBody != null)
            {
                yield return GetDefaultCase(defaultBody, context);
            }
        }

        private static string GetDefaultCase(Expression defaultBody, TranslationContext context)
        {
            var defaultCaseBody = context.TranslateCodeBlock(defaultBody);

            return GetCase(defaultCaseBody, "default:");
        }
    }
}