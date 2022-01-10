using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace ReSharperPlugin.CodeVision
{
    [ElementProblemAnalyzer(
        typeof(ICSharpFunctionDeclaration),
        HighlightingTypes = new[] { typeof(SampleInlayHint) })]
    public class SampleHintElementAnalyzer : ElementProblemAnalyzer<ICSharpFunctionDeclaration>
    {
        protected override void Run(
            ICSharpFunctionDeclaration element,
            ElementProblemAnalyzerData data,
            IHighlightingConsumer consumer)
        {
            consumer.AddHighlighting(new SampleInlayHint(element, element.NameIdentifier.GetDocumentStartOffset()));
        }
    }
}
