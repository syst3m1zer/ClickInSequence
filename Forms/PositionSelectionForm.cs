using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickInSequence.Forms
{
    public partial class PositionSelectionForm : Form
    {
        private int selectorPosX = 0, selectorPosY = 0;
        private PictureBox screen;
        private Panel selector;
        private Label POS;
        private System.Windows.Forms.Timer selectTimer;
        public PositionSelectionForm(Bitmap screenshot, Size screenResolution)
        {
            InitializeComponent();

            selector = new Panel
            {
                Location = new Point(64, 64),
                Size = new Size(10, 10),
                BackColor = Color.Orange
            };

            Label information = new Label
            {
                AutoSize = true,
                Location = new Point(8, 5),
                Text = "Press space to select the position. Enter for finish",
                ForeColor = Color.Orange,
                Font = new Font("Impact", 12.75F)
            };

            POS = new Label
            {
                AutoSize = true,
                Location = new Point(screenResolution.Width - (screenResolution.Width / 4), 5),
                Text = "POS(0|0)",
                ForeColor = Color.Orange,
                Font = new Font("Impact", 14.75F)
            };

            information.BringToFront();
            POS.BringToFront();

            screen = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.Normal,
                Dock = DockStyle.Fill
            };

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.DrawRectangle(new Pen(Brushes.Orange, 8), new Rectangle(0, 0, screenshot.Width, screenshot.Height));
            }
            screen.Image = screenshot;

            Controls.Add(screen);
            screen.Controls.Add(information);
            screen.Controls.Add(POS);
            screen.Controls.Add(selector);

            selectTimer = new System.Windows.Forms.Timer();
            selectTimer.Tick += SelectorMover;
            selectTimer.Interval = 10;
            selectTimer.Start();
        }

        private void SelectorMover(object sender, EventArgs e)
        {
            selector.Location = Cursor.Position;
        }

        private void PositionSelectionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                selectorPosX = selector.Location.X;
                selectorPosY = selector.Location.Y;
                POS.Text = $"POS({selectorPosX}|{selectorPosY})";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (selectorPosX != 0 && selectorPosY != 0)
                {
                    Hide();
                    Thread.Sleep(20);
                    Home.o_Position = new Point(selectorPosX, selectorPosY);
                }
            }
        }
    }
}
