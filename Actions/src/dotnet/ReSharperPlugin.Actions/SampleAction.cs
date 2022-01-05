using JetBrains.Application.DataContext;
using JetBrains.Application.UI.Actions;
using JetBrains.Application.UI.ActionsRevised.Menu;
using JetBrains.Util;

namespace ReSharperPlugin.Actions
{
    [Action(
        ActionId: Id,
        Text: "Sample Action",
        IdeaShortcuts = new[] { "Shift+Control+I" },
        VsShortcuts = new[] { "Shift+Control+I" })]
    public class SampleAction : IExecutableAction
    {
        // This is also shown in Visual Studio Options > Keyboard > Shortcuts
        public const string Id = nameof(SampleAction);

        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            return true;
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            MessageBox.ShowInfo("Action executed");
        }
    }
}
