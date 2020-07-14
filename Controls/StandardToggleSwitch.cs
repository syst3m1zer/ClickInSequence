using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickInSequence
{
    public class StandardToggleSwitch : Control
    {
        public bool mode { get; set; } = false;
        public Color enabledColor { get; set; } = Color.Red;
        private int togglePosXEnabled,
            togglePosXDisabled;
        Rectangle rectangle;
       
        public StandardToggleSwitch()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(20, 16);
            Font = new Font("Impact", 9F, FontStyle.Regular);
            BackColor = Color.Green;
            togglePosXDisabled = rectangle.X;
            togglePosXEnabled = rectangle.Width - rectangle.Height;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            Pen pen = new Pen(Color.Transparent, 3),
                penToggle = new Pen(Color.White, 1);
            rectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectangleToogle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Height, rectangle.Height);
            GraphicsPath rectanglePath = RoundedRectangle(rectangle, rectangle.Height);

            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            graph.DrawPath(pen, rectanglePath);


            switch (mode)
            {
                case true:
                    rectangleToogle.Location = new Point(togglePosXEnabled, rectangle.Y);
                    graph.FillPath(new SolidBrush(Color.LimeGreen), rectanglePath);
                    break;
                case false:
                    rectangleToogle.Location = new Point(togglePosXDisabled, rectangle.Y);
                    graph.FillPath(new SolidBrush(Color.DarkGray), rectanglePath);
                    break;
                default:
                    rectangleToogle.Location = new Point(togglePosXDisabled, rectangle.Y);
                    graph.FillPath(new SolidBrush(Color.DarkGray), rectanglePath);
                    break;
            }
            graph.DrawEllipse(penToggle, rectangleToogle);
            graph.FillEllipse(new SolidBrush(Color.Gray), rectangleToogle);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            rectangle = new Rectangle(1, 1, Width - 3, Height - 3);
            togglePosXDisabled = rectangle.X;
            togglePosXEnabled = rectangle.Width - rectangle.Height;

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            SwitchToggle();
        }

        private void SwitchToggle()
        {
            mode = !mode;
            Invalidate();
        }

        private GraphicsPath RoundedRectangle(Rectangle rectangle, int Size)
        {
            GraphicsPath path = new GraphicsPath() { FillMode = FillMode.Alternate };

            path.AddArc(rectangle.X, rectangle.Y, Size, Size, 180, 90);
            path.AddArc(rectangle.X + rectangle.Width - Size, rectangle.Y, Size, Size, 270, 90);
            path.AddArc(rectangle.X + rectangle.Width - Size, rectangle.Y + rectangle.Height - Size, Size, Size, 0, 90);
            path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - Size, Size, Size, 90, 90);

            return path;
        }
    }
}
