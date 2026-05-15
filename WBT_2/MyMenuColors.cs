using System.Drawing;
using System.Windows.Forms;

namespace WBT_2
{
    public class MyMenuColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(45, 45, 45);
        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(55, 55, 55);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(55, 55, 55);
        public override Color ToolStripDropDownBackground => Color.FromArgb(28, 28, 28);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(60, 60, 60);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(60, 60, 60);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(60, 60, 60);
        public override Color ImageMarginGradientBegin => Color.FromArgb(32, 32, 32);
        public override Color ImageMarginGradientEnd => Color.FromArgb(32, 32, 32);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(32, 32, 32);
        public override Color CheckBackground => Color.FromArgb(60, 60, 60);
        public override Color CheckSelectedBackground => Color.FromArgb(80, 80, 80);
        public override Color CheckPressedBackground => Color.FromArgb(100, 100, 100);
    }
}