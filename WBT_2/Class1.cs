using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBT_2
{
    public class MyMenuColors : ProfessionalColorTable
    {
        // Цвет фона элемента, когда на него навели мышкой (Hover)
        public override Color MenuItemSelected => Color.FromArgb(45, 45, 45);

        // Цвет рамки вокруг выделенного элемента (лучше сделать прозрачным)
        public override Color MenuItemBorder => Color.Transparent;

        // Цвет фона элемента, когда на него нажали (Dropped Down)
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(55, 55, 55);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(55, 55, 55);

        // Цвет фона открытого выпадающего меню
        public override Color ToolStripDropDownBackground => Color.FromArgb(28, 28, 28);

        public override Color MenuItemPressedGradientBegin => Color.FromArgb(60, 60, 60);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(60, 60, 60);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(60, 60, 60);
    }
}
