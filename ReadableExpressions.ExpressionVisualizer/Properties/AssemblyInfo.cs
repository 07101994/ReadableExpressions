﻿using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using AgileObjects.ReadableExpressions.ExpressionVisualizer;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AgileObjects.ReadableExpressions.ExpressionVisualizer")]
[assembly: AssemblyDescription("A Debugger Visualizer Providing a readable string representation of an Expression")]
[assembly: AssemblyCompany("AgileObjects Ltd")]
[assembly: AssemblyProduct("AgileObjects.ReadableExpressions.ExpressionVisualizer")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: NeutralResourcesLanguage("en")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1df26474-08fc-45bb-a0c3-7634bd0b6c0f")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(Expression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(BinaryExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(BlockExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(ConditionalExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(ConstantExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(DebugInfoExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(DefaultExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(DynamicExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(GotoExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(IndexExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(InvocationExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(LabelExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(LambdaExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(ListInitExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(LoopExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(MemberExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(MemberInitExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(MethodCallExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(NewArrayExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(NewExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(ParameterExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(RuntimeVariablesExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(SwitchExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(TryExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(TypeBinaryExpression), Description = "ReadableExpressions Visualizer")]
[assembly: DebuggerVisualizer(typeof(Vs2015ExpressionVisualizer), typeof(ExpressionVisualizerObjectSource), Target = typeof(UnaryExpression), Description = "ReadableExpressions Visualizer")]