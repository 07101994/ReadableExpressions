﻿namespace AgileObjects.ReadableExpressions.ExpressionVisualizer
{
    using Microsoft.VisualStudio.DebuggerVisualizers;

    public class Vs14ExpressionVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(
            IDialogVisualizerService windowService,
            IVisualizerObjectProvider objectProvider)
        {
            ExpressionDialog.Show(objectProvider.GetObject().ToString());
        }
    }
}
