using System.ComponentModel;

namespace Wox.Plugin.TodoPlus
{
    public enum TodoCommand
    {
        [Description("List")]
        L,
        [Description("Add")]
        A,
        [Description("Complete")]
        C,
        [Description("Remove")]
        R,
        [Description("Help")]
        H,
        [Description("Reload")]
        Rl
    }
}
