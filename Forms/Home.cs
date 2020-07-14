using ClickInSequence.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickInSequence
{
    public partial class Home : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Point c_position;
        private bool pauser = false;
        private int vScrollStep = 80;
        private int scrollValue = 0;
        private List<MouseAction> mouseActions = new List<MouseAction>();

        private int ScrollValue
        {
            get
            {
                return scrollValue;
            }
            set
            {
                scrollValue = value;

                if (scrollValue < itemList.VerticalScroll.Minimum)
                {
                    scrollValue = itemList.VerticalScroll.Minimum;
                }

                if (scrollValue > itemList.VerticalScroll.Maximum)
                {
                    scrollValue = itemList.VerticalScroll.Maximum;
                }

                itemList.VerticalScroll.Value = scrollValue;
                itemList.PerformLayout();
            }
        }

        int processCount = 0;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ApplicationClose();
                pauser = true;
                if (processCount >= 2)
                {
                    ApplicationClose();
                    pauser = true;
                      
                }
                processCount++;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region InitializeDesign
        public void InitializeDesign()
        {
            versionLabel.Text = $"Beta version b{Assembly.GetEntryAssembly().GetName().Version}";   
            minimizeScreenBoxLabel.Text = "<";
            screenMirorBox.Location = new Point(650, screenMirorBox.Bounds.Y);
            BackColor = HtmlToColor("#2D2D30");
            bpanelA.BackColor = HtmlToColor("#46464A");
            exitBPanel.BackColor = HtmlToColor("#46464A");
            button_exit.BackColor = HtmlToColor("#2D2D30");
            button_exit.ButtonColor = HtmlToColor("#2D2D30");
            button_exit.ButtonColor = HtmlToColor("#2D2D30");
            button_exit.FlatAppearance.MouseOverBackColor = HtmlToColor("#2D2D30");
            button_exit.FlatAppearance.MouseDownBackColor = HtmlToColor("#2D2D30"); 
            button_settings.BackColor = HtmlToColor("#2D2D30");
            button_settings.ButtonColor = HtmlToColor("#2D2D30");
            button_settings.ButtonColor = HtmlToColor("#2D2D30");
            button_settings.FlatAppearance.MouseOverBackColor = HtmlToColor("#2D2D30");
            button_settings.FlatAppearance.MouseDownBackColor = HtmlToColor("#2D2D30");
            addBTN.BackColor = HtmlToColor("#2D2D30");
            addBTN.ButtonColor = HtmlToColor("#2D2D30");
            addBTN.ButtonColor = HtmlToColor("#2D2D30");
            addBTN.FlatAppearance.MouseOverBackColor = HtmlToColor("#2D2D30");
            addBTN.FlatAppearance.MouseDownBackColor = HtmlToColor("#2D2D30");
            startBTN.BackColor = HtmlToColor("#2D2D30");
            startBTN.ButtonColor = HtmlToColor("#2D2D30");
            startBTN.ButtonColor = HtmlToColor("#2D2D30");
            startBTN.FlatAppearance.MouseOverBackColor = HtmlToColor("#2D2D30");
            startBTN.FlatAppearance.MouseDownBackColor = HtmlToColor("#2D2D30");
            bpanelA.MouseDown += Home_MouseDown;
            exitBPanel.MouseEnter += Close_MouseEnter;
            exitBPanel.MouseLeave += Close_MouseLeave;
            exitBPanel.MouseClick += ExitPanel_MouseClick;
            minimizeBPanel.BackColor = HtmlToColor("#46464A");
            minimizeBPanel.MouseEnter += Minimize_MouseEnter;
            minimizeBPanel.MouseLeave += Minimize_MouseLeave;
            minimizeBPanel.MouseClick += Minimize_MouseClick;
            closeLabel.MouseEnter += Close_MouseEnter;
            closeLabel.MouseLeave += Close_MouseLeave;
            closeLabel.MouseClick += ExitPanel_MouseClick;
            minimizeLabel.MouseEnter += Minimize_MouseEnter;
            minimizeLabel.MouseLeave += Minimize_MouseLeave;
            minimizeLabel.MouseClick += Minimize_MouseClick;
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            ApplicationClose();
        }
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            exitBPanel.BackColor = HtmlToColor("#007ACC");
            closeLabel.BackColor = HtmlToColor("#007ACC");
        }
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            exitBPanel.BackColor = HtmlToColor("#46464A");
            closeLabel.BackColor = HtmlToColor("#46464A");
        }
        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            minimizeBPanel.BackColor = HtmlToColor("#007ACC");
            minimizeLabel.BackColor = HtmlToColor("#007ACC");
        }
        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            minimizeBPanel.BackColor = HtmlToColor("#46464A");
            minimizeLabel.BackColor = HtmlToColor("#46464A");
        }
        private void ExitPanel_MouseClick(object sender, MouseEventArgs e)
        {
            exitBPanel.BackColor = HtmlToColor("#2A2A2B");
            closeLabel.BackColor = HtmlToColor("#2A2A2B");
            ApplicationClose();
        }
        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            minimizeBPanel.BackColor = HtmlToColor("#2A2A2B");
            minimizeLabel.BackColor = HtmlToColor("#2A2A2B");
            ApplicationMinimize();
        }

        private void mirrorSwitch_Click(object sender, EventArgs e)
        {
            mirrorMode = mirrorSwitch.mode;
            if (!mirrorSwitch.mode)
            {
                Bitmap img = (Bitmap)screenMirror.Image;
                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        img.SetPixel(x, y, Color.Black);
                    }
                }

                screenMirror.Image = img;

                if (minimizeScreenBoxLabel.Text.Equals(">"))
                {
                    ScreenBoxZoom(minimizeScreenBoxLabel.Text);
                }
            }
        }

        private void screens_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedScreen = int.Parse(screens.Text);
        }

        private bool lastMirrorMode = false;
        private void minimizeScreenBoxLabel_Click(object sender, EventArgs e)
        {
            ScreenBoxZoom(minimizeScreenBoxLabel.Text);
        }
        private void delayTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static Point o_Position;
        System.Windows.Forms.Timer selectionTimer, finishTimer;
        private void selectBTN_Click(object sender, EventArgs e)
        {
            if (!screenCombo.Text.Equals(""))
            {
                MessageBox.Show("Program becomes temporarily invisible to make a screenshot. This needs 1.5 seconds.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                Hide();

                selectionTimer = new System.Windows.Forms.Timer();
                selectionTimer.Tick += Timer_Tick;
                selectionTimer.Interval = 1000;
                selectionTimer.Start();

                finishTimer = new System.Windows.Forms.Timer();
                finishTimer.Tick += Finish_Time;
                finishTimer.Interval = 3;
                finishTimer.Start();
            }
            else
            {
                MessageBox.Show("Select a screen first", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Finish_Time(object sender, EventArgs e)
        {
            if (!o_Position.IsEmpty)
            {
                finishTimer.Stop();
                selectBTN.Text = $"{o_Position.X}|{o_Position.Y}";
                selectBTN.MouseEnter += SelectBTN_MouseEnter;
                selectBTN.MouseLeave += SelectBTN_MouseLeave;
                c_position = o_Position;
                o_Position = new Point();
            }
        }

        private void SelectBTN_MouseLeave(object sender, EventArgs e)
        {
            selectBTN.Text = $"{c_position.X}|{c_position.Y}";
        }

        private void SelectBTN_MouseEnter(object sender, EventArgs e)
        {
            selectBTN.Text = "Select";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            selectionTimer.Stop();
            int selectedScreen = int.Parse(screenCombo.Text);
            Bitmap screenshot = Screenshot(selectedScreen);
            Size screenResolution = new Size(Screen.AllScreens[selectedScreen].Bounds.Width,
                Screen.AllScreens[selectedScreen].Bounds.Height);
            PositionSelectionForm form = new PositionSelectionForm(screenshot, screenResolution);
            form.ShowDialog();
            Show();
        }
 
        private void ScreenBoxZoom(string val)
        {
            if (minimizeScreenBoxLabel.Text.Equals(">"))
            {
                lastMirrorMode = mirrorMode;
                mirrorMode = false;
                int count = 351;
                while (count < 650)
                {
                    count += 12;
                    Thread.Sleep(6);
                    screenMirorBox.Location = new Point(count, screenMirorBox.Bounds.Y);
                }
                minimizeScreenBoxLabel.Text = "<";
            }
            else if (minimizeScreenBoxLabel.Text.Equals("<"))
            {
                int count = 650;
                while (count > 351)
                {
                    count -= 12;
                    Thread.Sleep(6);
                    screenMirorBox.Location = new Point(count, screenMirorBox.Bounds.Y);
                }
                minimizeScreenBoxLabel.Text = ">";
                mirrorMode = lastMirrorMode;
            }
        }
        #endregion

        #region WindowUtility
        private void ApplicationClose()
        {
            Close();
            Environment.Exit(0x1);
            Application.Exit();
        }
        private void ApplicationMinimize()
        {
            int width = Size.Width,
                height = Size.Height;
            int width_count = width,
                height_count = height;

            while (height_count > 25)
            {
                height_count -= 8;
                Thread.Sleep(4);
                Size = new Size(width_count, height_count);
            }

            while (width_count > 0)
            {
                width_count -= 8;
                Thread.Sleep(1);
                Size = new Size(width_count, height_count);
            }

            WindowState = FormWindowState.Minimized;
            Size = new Size(width, height);
        }
        #endregion

        #region DynamicObjects
        Bitmap screen;
        private void InitializeDynamicObjects()
        {
            SetUpComboBoxScreen();
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            if (resolution.Width > 800 && resolution.Height > 900)
            {
                screenMirror.BorderStyle = BorderStyle.FixedSingle;
                screenMirror.SizeMode = PictureBoxSizeMode.StretchImage;
                ScreenMirror(resolution);
            }
        }

        private Bitmap Screenshot(int screen)
        {
            int widthScreen = Screen.AllScreens[screen].Bounds.Width;
            int heightScreen = Screen.AllScreens[screen].Bounds.Height;

            Bitmap bmap = new Bitmap(widthScreen, heightScreen);
            Graphics graphic = Graphics.FromImage(bmap);
            graphic.CopyFromScreen(Screen.AllScreens[screen].Bounds.X,
                Screen.AllScreens[screen].Bounds.Y,
                0,
                0,
                Screen.AllScreens[screen].Bounds.Size,
                CopyPixelOperation.SourceCopy);
            graphic.Dispose();

            return bmap;
        }

        private void SetUpComboBoxScreen()
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                screens.Items.Add(i);
                screenCombo.Items.Add(i);
            }
        }

        int selectedScreen = 0;
        bool mirrorMode = false;
        private void ScreenMirror(Rectangle resolution)
        {
            int widthScreen = resolution.Width,
                heightScreen = resolution.Height;
            new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1800);
                    while (mirrorMode)
                    {
                        Thread.Sleep(40);

                        widthScreen = Screen.AllScreens[selectedScreen].Bounds.Width;
                        heightScreen = Screen.AllScreens[selectedScreen].Bounds.Height;

                        try
                        {
                            Bitmap bmap = new Bitmap(widthScreen, heightScreen);
                            Graphics graphic = Graphics.FromImage(bmap);
                            graphic.CopyFromScreen(Screen.AllScreens[selectedScreen].Bounds.X,
                                Screen.AllScreens[selectedScreen].Bounds.Y,
                                0,
                                0,
                                Screen.AllScreens[selectedScreen].Bounds.Size,
                                CopyPixelOperation.SourceCopy);
                            graphic.Dispose();

                            // Draw mouse

                            int mousePosX = Cursor.Position.X,
                                mousePosY = Cursor.Position.Y;

                            try
                            {
                                for (int i = 0; i < 18; i++)
                                {
                                    for (int j = 0; j < 18; j++)
                                    {
                                        bmap.SetPixel(mousePosX + j, mousePosY + i, Color.Red);
                                    }
                                }
                            }
                            catch { }

                            screen = bmap;
                            screenMirror.Image = screen;
                        } catch { }
                    }
                }
            }).Start();
        }

        #endregion

        Panel item;
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (!screenCombo.Text.Equals("") && !clickTypeCombo.Text.Equals("") && !delayTXT.Text.Equals(""))
            {
                item = new Panel()
                {
                    Width = 110,
                    Height = 80,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label screenLabel = new Label()
                {
                    AutoSize = true,
                    Location = new Point(3, 1),
                    Font = new Font("Impact", 7F),
                    ForeColor = Color.Orange,
                    Text = $"Screen: {screenCombo.Text}"
                };

                Label removeBtn = new Label()
                {
                    AutoSize = true,
                    Location = new Point(3, 50),
                    Font = new Font("Impact", 7F),
                    ForeColor = Color.Orange,
                    Text = $"X"
                };
                removeBtn.MouseClick += RemoveBtn_MouseClick;

                Label positionLabel = new Label()
                {
                    AutoSize = true,
                    Location = new Point(3, 18),
                    Font = new Font("Impact", 7F),
                    ForeColor = Color.Orange,
                    Text = $"Position: POS({c_position.X}|{c_position.Y}"
                };

                Label clickTypeLabel = new Label()
                {
                    AutoSize = true,
                    Location = new Point(3, 36),
                    Font = new Font("Impact", 7F),
                    ForeColor = Color.Orange,
                    Text = $"Click Type: {clickTypeCombo.Text}"
                };

                Label delayLabel = new Label()
                {
                    AutoSize = true,
                    Location = new Point(3, 54),
                    Font = new Font("Impact", 7F),
                    ForeColor = Color.Orange,
                    Text = $"Delay: {delayTXT.Text}"
                };

                screenLabel.BringToFront();
                positionLabel.BringToFront();
                clickTypeLabel.BringToFront();
                delayLabel.BringToFront();

                item.Controls.Add(screenLabel);
                item.Controls.Add(positionLabel);
                item.Controls.Add(clickTypeLabel);
                item.Controls.Add(delayLabel);

                itemList.Controls.Add(item);

                short mouseType = 0;
                switch (clickTypeCombo.Text)
                {
                    case "Right":
                        mouseType = 0;
                        break;
                    case "Left":
                        mouseType = 1;
                        break;
                    case "Middle":
                        mouseType = 2;
                        break;
                }

                mouseActions.Add(new MouseAction(short.Parse(screenCombo.Text),
                    mouseType, int.Parse(delayTXT.Text), c_position,
                    new Size(int.Parse(screenResolutionTxt.Text.Split(':')[0]),
                    int.Parse(screenResolutionTxt.Text.Split(':')[1]))));
            }
            else
            {
                MessageBox.Show("Not all components were described.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        int i = 0;
        private void scrollUpButton_Click(object sender, EventArgs e)
        {
            if (i >= 0) i = -1;
           // itemList.ScrollUp(i--);
        }

        private void scrollDownButton_Click(object sender, EventArgs e)
        {
            if (i < 0) i = 0;
           // itemList.ScrollUp(i++);
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            Opacity = 0;

            int times = int.Parse(timesTXT.Text);
            bool unlimited = false;
            if (times == 0)
            {
                unlimited = true;
                times = 1;
            }

            if (unlimited)
            {
                while (!pauser)
                {
                    Thread.Sleep(1);
                    Start();
                }
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    Thread.Sleep(1);
                    Start();
                }
            }
            Opacity = 100;
            MessageBox.Show("Mouse Action Closed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Start()
        {
            foreach (MouseAction mouseAction in mouseActions)
            {
                Point location = mouseAction.MousePosition;
                if (mouseAction.Screen != 0)
                {
                    location = new Point(location.X + mouseAction.ScreenResolution.Width,
                        location.Y + mouseAction.ScreenResolution.Height);
                }
                Cursor.Position = location;

                Thread.Sleep(mouseAction.Delay);

                int[] MOUSE_EVENT_CLICK_TYPE = new int[2];
                switch (mouseAction.ClickType)
                {
                    case 0:
                        MOUSE_EVENT_CLICK_TYPE[0] = MouseOperations.MOUSEEVENTF_RIGHTDOWN;
                        MOUSE_EVENT_CLICK_TYPE[1] = MouseOperations.MOUSEEVENTF_RIGHTUP;
                        break;
                    case 1:
                        MOUSE_EVENT_CLICK_TYPE[0] = MouseOperations.MOUSEEVENTF_LEFTDOWN;
                        MOUSE_EVENT_CLICK_TYPE[1] = MouseOperations.MOUSEEVENTF_LEFTUP;
                        break;
                    case 2:
                        MOUSE_EVENT_CLICK_TYPE[0] = MouseOperations.MOUSEEVENTF_MIDDLEDOWN;
                        MOUSE_EVENT_CLICK_TYPE[1] = MouseOperations.MOUSEEVENTF_MIDDLEUP;
                        break;
                }

                MouseOperations.Click(location, MOUSE_EVENT_CLICK_TYPE[0], MOUSE_EVENT_CLICK_TYPE[1]);
            }
        }

        private void screenCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            screenResolutionTxt.Text = 
                $"{Screen.AllScreens[int.Parse(screenCombo.Text)].Bounds.Width}:" +
                $"{Screen.AllScreens[int.Parse(screenCombo.Text)].Bounds.Height}";
        }

        private void removeAllBTN_Click(object sender, EventArgs e)
        {
            mouseActions.Clear();
            itemList.Controls.Clear();
        }

        public Home()
        {
            InitializeComponent();
            InitializeDesign();
            InitializeDynamicObjects();
        }
    }
}
