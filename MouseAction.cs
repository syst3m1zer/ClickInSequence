using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickInSequence
{
    class MouseAction
    {
        public short Screen { get; set; }
        // Mouse : 0 = Right; 1 = Left; 2 = Middle
        public short ClickType { get; set; }
        public int Delay { get; set; }
        public Point MousePosition { get; set; }
        public Size ScreenResolution { get; set; }
        public MouseAction(short screen, short clickType, int delay, Point mousePosition, Size screenResolution)
        {
            Screen = screen;
            Delay = delay;
            ClickType = clickType;
            MousePosition = mousePosition;
            ScreenResolution = screenResolution;
        }
    }
}
