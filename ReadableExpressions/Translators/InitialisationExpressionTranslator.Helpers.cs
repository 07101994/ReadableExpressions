﻿namespace AgileObjects.ReadableExpressions.Translators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    internal partial class InitialisationExpressionTranslator
    {
        private interface IInitExpressionHelper
        {
            string Translate(Expression expression, IExpressionTranslatorRegistry translatorRegistry);
        }

        private abstract class InitExpressionHelperBase<TExpression, TNewExpression> : IInitExpressionHelper
            where TExpression : Expression
            where TNewExpression : Expression
        {
            public string Translate(Expression expression, IExpressionTranslatorRegistry translatorRegistry)
            {
                var typedExpression = (TExpression)expression;
                var newExpression = GetNewExpression(typedExpression, translatorRegistry);
                var initialisations = GetInitialisations(typedExpression, translatorRegistry);

                if ((newExpression.Length + initialisations.Sum(init => init.Length+ 2)) <= 40)
                {
                    return newExpression + " { " + string.Join(", ", initialisations) + " }";
                }

                return newExpression + Environment.NewLine +
                    "{" + Environment.NewLine +
                        string.Join(
                            "," + Environment.NewLine,
                            initialisations.Select(init => "    " + init)) +
                    Environment.NewLine + "}";
            }

            private string GetNewExpression(
                TExpression initialisation,
                IExpressionTranslatorRegistry translatorRegistry)
            {
                var newExpression = GetNewExpression(initialisation);
                var newExpressionString = translatorRegistry.Translate(newExpression);

                if (ConstructorIsParameterless(newExpression))
                {
                    // Remove the empty brackets:
                    newExpressionString = newExpressionString.Substring(0, newExpressionString.Length - 2);
                }

                return newExpressionString;
            }

            protected abstract TNewExpression GetNewExpression(TExpression expression);

            protected abstract bool ConstructorIsParameterless(TNewExpression newExpression);

            protected abstract IEnumerable<string> GetInitialisations(
                TExpression expression,
                IExpressionTranslatorRegistry translatorRegistry);
        }
    }
}
