using JetBrains.Application;
using JetBrains.Lifetimes;
using JetBrains.ReSharper.Feature.Services.QuickFixes;

namespace ReSharperPlugin.CodeInspections;

[ShellComponent]
internal class SampleQuickFixRegistrarComponent
{
    public SampleQuickFixRegistrarComponent(IQuickFixesRegistrar registrar)
    {
        registrar.RegisterQuickFix<SampleHighlighting>(Lifetime.Eternal, h => new SampleFix(h.Declaration), typeof(SampleFix));
    }
}