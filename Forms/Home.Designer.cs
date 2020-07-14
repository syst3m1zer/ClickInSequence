using System.Drawing;

namespace ClickInSequence
{
    partial class Home
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Color HtmlToColor(string code)
        {
            return (Color)System.Drawing.ColorTranslator.FromHtml(code);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.bpanelA = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.minimizeBPanel = new System.Windows.Forms.Panel();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.exitBPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.screenMirror = new System.Windows.Forms.PictureBox();
            this.screenMirorBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minimizeScreenBoxLabel = new System.Windows.Forms.Label();
            this.screens = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mirrorSwitch = new ClickInSequence.StandardToggleSwitch();
            this.versionLabel = new System.Windows.Forms.Label();
            this.clickTypeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delayTXT = new System.Windows.Forms.TextBox();
            this.selectBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.screenCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timesTXT = new System.Windows.Forms.TextBox();
            this.itemList = new System.Windows.Forms.FlowLayoutPanel();
            this.scrollDownButton = new System.Windows.Forms.Button();
            this.scrollUpButton = new System.Windows.Forms.Button();
            this.screenResolutionTxt = new System.Windows.Forms.Label();
            this.removeAllBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startBTN = new ClickInSequence.Controls.StandardEdgedButton();
            this.addBTN = new ClickInSequence.Controls.StandardEdgedButton();
            this.button_exit = new ClickInSequence.Controls.StandardEdgedButton();
            this.button_settings = new ClickInSequence.Controls.StandardEdgedButton();
            this.bpanelA.SuspendLayout();
            this.minimizeBPanel.SuspendLayout();
            this.exitBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenMirror)).BeginInit();
            this.screenMirorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bpanelA
            // 
            this.bpanelA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bpanelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpanelA.Controls.Add(this.logoLabel);
            this.bpanelA.Controls.Add(this.minimizeBPanel);
            this.bpanelA.Controls.Add(this.exitBPanel);
            this.bpanelA.Dock = System.Windows.Forms.DockStyle.Top;
            this.bpanelA.Location = new System.Drawing.Point(0, 0);
            this.bpanelA.Name = "bpanelA";
            this.bpanelA.Size = new System.Drawing.Size(700, 25);
            this.bpanelA.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.Orange;
            this.logoLabel.Location = new System.Drawing.Point(-1, -2);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(173, 26);
            this.logoLabel.TabIndex = 3;
            this.logoLabel.Text = "ClickInSequence";
            this.logoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            // 
            // minimizeBPanel
            // 
            this.minimizeBPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimizeBPanel.Controls.Add(this.minimizeLabel);
            this.minimizeBPanel.Location = new System.Drawing.Point(600, -1);
            this.minimizeBPanel.Name = "minimizeBPanel";
            this.minimizeBPanel.Size = new System.Drawing.Size(50, 25);
            this.minimizeBPanel.TabIndex = 2;
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.AutoSize = true;
            this.minimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeLabel.Location = new System.Drawing.Point(13, -7);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(25, 26);
            this.minimizeLabel.TabIndex = 2;
            this.minimizeLabel.Text = "_";
            // 
            // exitBPanel
            // 
            this.exitBPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitBPanel.Controls.Add(this.closeLabel);
            this.exitBPanel.Location = new System.Drawing.Point(649, -1);
            this.exitBPanel.Name = "exitBPanel";
            this.exitBPanel.Size = new System.Drawing.Size(50, 25);
            this.exitBPanel.TabIndex = 1;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.closeLabel.Location = new System.Drawing.Point(14, 1);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(19, 20);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            // 
            // screenMirror
            // 
            this.screenMirror.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenMirror.Location = new System.Drawing.Point(22, 51);
            this.screenMirror.Name = "screenMirror";
            this.screenMirror.Size = new System.Drawing.Size(310, 170);
            this.screenMirror.TabIndex = 2;
            this.screenMirror.TabStop = false;
            // 
            // screenMirorBox
            // 
            this.screenMirorBox.Controls.Add(this.label2);
            this.screenMirorBox.Controls.Add(this.minimizeScreenBoxLabel);
            this.screenMirorBox.Controls.Add(this.screens);
            this.screenMirorBox.Controls.Add(this.label1);
            this.screenMirorBox.Controls.Add(this.screenMirror);
            this.screenMirorBox.Controls.Add(this.mirrorSwitch);
            this.screenMirorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenMirorBox.Location = new System.Drawing.Point(650, 207);
            this.screenMirorBox.Name = "screenMirorBox";
            this.screenMirorBox.Size = new System.Drawing.Size(337, 225);
            this.screenMirorBox.TabIndex = 4;
            this.screenMirorBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Demo Screen";
            // 
            // minimizeScreenBoxLabel
            // 
            this.minimizeScreenBoxLabel.AutoSize = true;
            this.minimizeScreenBoxLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeScreenBoxLabel.ForeColor = System.Drawing.Color.Orange;
            this.minimizeScreenBoxLabel.Location = new System.Drawing.Point(11, 25);
            this.minimizeScreenBoxLabel.Name = "minimizeScreenBoxLabel";
            this.minimizeScreenBoxLabel.Size = new System.Drawing.Size(19, 20);
            this.minimizeScreenBoxLabel.TabIndex = 7;
            this.minimizeScreenBoxLabel.Text = ">";
            this.minimizeScreenBoxLabel.Click += new System.EventHandler(this.minimizeScreenBoxLabel_Click);
            // 
            // screens
            // 
            this.screens.FormattingEnabled = true;
            this.screens.Location = new System.Drawing.Point(114, 25);
            this.screens.Name = "screens";
            this.screens.Size = new System.Drawing.Size(47, 21);
            this.screens.TabIndex = 6;
            this.screens.Text = "0";
            this.screens.SelectedIndexChanged += new System.EventHandler(this.screens_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Screen";
            // 
            // mirrorSwitch
            // 
            this.mirrorSwitch.BackColor = System.Drawing.Color.White;
            this.mirrorSwitch.enabledColor = System.Drawing.Color.Red;
            this.mirrorSwitch.Font = new System.Drawing.Font("Impact", 9F);
            this.mirrorSwitch.Location = new System.Drawing.Point(287, 22);
            this.mirrorSwitch.mode = false;
            this.mirrorSwitch.Name = "mirrorSwitch";
            this.mirrorSwitch.Size = new System.Drawing.Size(42, 22);
            this.mirrorSwitch.TabIndex = 2;
            this.mirrorSwitch.Text = "standardToggleSwitch1";
            this.mirrorSwitch.Click += new System.EventHandler(this.mirrorSwitch_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.Orange;
            this.versionLabel.Location = new System.Drawing.Point(601, 435);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(99, 17);
            this.versionLabel.TabIndex = 9;
            this.versionLabel.Text = "Beta version b0.1";
            // 
            // clickTypeCombo
            // 
            this.clickTypeCombo.BackColor = System.Drawing.Color.Orange;
            this.clickTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clickTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickTypeCombo.ForeColor = System.Drawing.Color.White;
            this.clickTypeCombo.FormattingEnabled = true;
            this.clickTypeCombo.Items.AddRange(new object[] {
            "Right",
            "Left",
            "Middle"});
            this.clickTypeCombo.Location = new System.Drawing.Point(301, 35);
            this.clickTypeCombo.Name = "clickTypeCombo";
            this.clickTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.clickTypeCombo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(237, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Click Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(426, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Delay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(104, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(531, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "ms";
            // 
            // delayTXT
            // 
            this.delayTXT.BackColor = System.Drawing.Color.Orange;
            this.delayTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delayTXT.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayTXT.ForeColor = System.Drawing.Color.White;
            this.delayTXT.Location = new System.Drawing.Point(467, 35);
            this.delayTXT.MaxLength = 8;
            this.delayTXT.Name = "delayTXT";
            this.delayTXT.Size = new System.Drawing.Size(62, 21);
            this.delayTXT.TabIndex = 0;
            this.delayTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayTXT_KeyPress);
            // 
            // selectBTN
            // 
            this.selectBTN.BackColor = System.Drawing.Color.Orange;
            this.selectBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBTN.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBTN.ForeColor = System.Drawing.Color.White;
            this.selectBTN.Location = new System.Drawing.Point(158, 32);
            this.selectBTN.Name = "selectBTN";
            this.selectBTN.Size = new System.Drawing.Size(75, 27);
            this.selectBTN.TabIndex = 18;
            this.selectBTN.Text = "Select";
            this.selectBTN.UseVisualStyleBackColor = false;
            this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(9, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Screen";
            // 
            // screenCombo
            // 
            this.screenCombo.BackColor = System.Drawing.Color.Orange;
            this.screenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenCombo.ForeColor = System.Drawing.Color.White;
            this.screenCombo.FormattingEnabled = true;
            this.screenCombo.Location = new System.Drawing.Point(55, 35);
            this.screenCombo.Name = "screenCombo";
            this.screenCombo.Size = new System.Drawing.Size(44, 21);
            this.screenCombo.TabIndex = 20;
            this.screenCombo.SelectedIndexChanged += new System.EventHandler(this.screenCombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(175, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Repeat Times (0 for unlimited)";
            // 
            // timesTXT
            // 
            this.timesTXT.BackColor = System.Drawing.Color.Orange;
            this.timesTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timesTXT.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesTXT.ForeColor = System.Drawing.Color.White;
            this.timesTXT.Location = new System.Drawing.Point(354, 367);
            this.timesTXT.MaxLength = 8;
            this.timesTXT.Name = "timesTXT";
            this.timesTXT.Size = new System.Drawing.Size(62, 21);
            this.timesTXT.TabIndex = 22;
            this.timesTXT.Text = "1";
            // 
            // itemList
            // 
            this.itemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemList.Location = new System.Drawing.Point(12, 63);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(628, 283);
            this.itemList.TabIndex = 24;
            // 
            // scrollDownButton
            // 
            this.scrollDownButton.BackColor = System.Drawing.Color.Orange;
            this.scrollDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollDownButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollDownButton.ForeColor = System.Drawing.Color.White;
            this.scrollDownButton.Location = new System.Drawing.Point(613, 317);
            this.scrollDownButton.Name = "scrollDownButton";
            this.scrollDownButton.Size = new System.Drawing.Size(25, 27);
            this.scrollDownButton.TabIndex = 25;
            this.scrollDownButton.Text = "▼";
            this.scrollDownButton.UseVisualStyleBackColor = false;
            this.scrollDownButton.Click += new System.EventHandler(this.scrollDownButton_Click);
            // 
            // scrollUpButton
            // 
            this.scrollUpButton.BackColor = System.Drawing.Color.Orange;
            this.scrollUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrollUpButton.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollUpButton.ForeColor = System.Drawing.Color.White;
            this.scrollUpButton.Location = new System.Drawing.Point(613, 65);
            this.scrollUpButton.Name = "scrollUpButton";
            this.scrollUpButton.Size = new System.Drawing.Size(25, 27);
            this.scrollUpButton.TabIndex = 26;
            this.scrollUpButton.Text = "▲";
            this.scrollUpButton.UseVisualStyleBackColor = false;
            this.scrollUpButton.Click += new System.EventHandler(this.scrollUpButton_Click);
            // 
            // screenResolutionTxt
            // 
            this.screenResolutionTxt.AutoSize = true;
            this.screenResolutionTxt.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenResolutionTxt.ForeColor = System.Drawing.Color.Orange;
            this.screenResolutionTxt.Location = new System.Drawing.Point(10, 22);
            this.screenResolutionTxt.Name = "screenResolutionTxt";
            this.screenResolutionTxt.Size = new System.Drawing.Size(21, 15);
            this.screenResolutionTxt.TabIndex = 27;
            this.screenResolutionTxt.Text = "0:0";
            // 
            // removeAllBTN
            // 
            this.removeAllBTN.BackColor = System.Drawing.Color.Orange;
            this.removeAllBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBTN.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllBTN.ForeColor = System.Drawing.Color.White;
            this.removeAllBTN.Location = new System.Drawing.Point(178, 409);
            this.removeAllBTN.Name = "removeAllBTN";
            this.removeAllBTN.Size = new System.Drawing.Size(75, 27);
            this.removeAllBTN.TabIndex = 28;
            this.removeAllBTN.Text = "Remove all";
            this.removeAllBTN.UseVisualStyleBackColor = false;
            this.removeAllBTN.Click += new System.EventHandler(this.removeAllBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(468, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "To escape press ESC two times";
            // 
            // startBTN
            // 
            this.startBTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.startBTN.BorderColor = System.Drawing.Color.Orange;
            this.startBTN.BorderThickness = 6;
            this.startBTN.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.startBTN.FlatAppearance.BorderSize = 0;
            this.startBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.startBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.Location = new System.Drawing.Point(561, 398);
            this.startBTN.Name = "startBTN";
            this.startBTN.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.startBTN.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.startBTN.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.startBTN.Size = new System.Drawing.Size(79, 34);
            this.startBTN.TabIndex = 23;
            this.startBTN.Text = "Start";
            this.startBTN.TextColor = System.Drawing.Color.White;
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addBTN.BorderColor = System.Drawing.Color.Orange;
            this.addBTN.BorderThickness = 6;
            this.addBTN.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.addBTN.FlatAppearance.BorderSize = 0;
            this.addBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.addBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(561, 30);
            this.addBTN.Name = "addBTN";
            this.addBTN.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.addBTN.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.addBTN.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.addBTN.Size = new System.Drawing.Size(79, 26);
            this.addBTN.TabIndex = 11;
            this.addBTN.Text = "Add";
            this.addBTN.TextColor = System.Drawing.Color.White;
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_exit.BorderColor = System.Drawing.Color.Orange;
            this.button_exit.BorderThickness = 6;
            this.button_exit.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(12, 398);
            this.button_exit.Name = "button_exit";
            this.button_exit.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.button_exit.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.button_exit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_exit.Size = new System.Drawing.Size(145, 40);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.TextColor = System.Drawing.Color.White;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_settings
            // 
            this.button_settings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_settings.BorderColor = System.Drawing.Color.Orange;
            this.button_settings.BorderThickness = 6;
            this.button_settings.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.Location = new System.Drawing.Point(12, 352);
            this.button_settings.Name = "button_settings";
            this.button_settings.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.button_settings.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.button_settings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_settings.Size = new System.Drawing.Size(145, 40);
            this.button_settings.TabIndex = 1;
            this.button_settings.Text = "Settings";
            this.button_settings.TextColor = System.Drawing.Color.White;
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.screenMirorBox);
            this.Controls.Add(this.removeAllBTN);
            this.Controls.Add(this.scrollUpButton);
            this.Controls.Add(this.scrollDownButton);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.screenCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectBTN);
            this.Controls.Add(this.delayTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clickTypeCombo);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.bpanelA);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.timesTXT);
            this.Controls.Add(this.screenResolutionTxt);
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "ClickInSequence";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bpanelA.ResumeLayout(false);
            this.bpanelA.PerformLayout();
            this.minimizeBPanel.ResumeLayout(false);
            this.minimizeBPanel.PerformLayout();
            this.exitBPanel.ResumeLayout(false);
            this.exitBPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenMirror)).EndInit();
            this.screenMirorBox.ResumeLayout(false);
            this.screenMirorBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bpanelA;
        private System.Windows.Forms.Panel minimizeBPanel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Panel exitBPanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox screenMirror;
        private StandardToggleSwitch mirrorSwitch;
        private System.Windows.Forms.GroupBox screenMirorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox screens;
        private System.Windows.Forms.Label minimizeScreenBoxLabel;
        private Controls.StandardEdgedButton button_settings;
        private Controls.StandardEdgedButton button_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label versionLabel;
        private Controls.StandardEdgedButton addBTN;
        private System.Windows.Forms.ComboBox clickTypeCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox delayTXT;
        private System.Windows.Forms.Button selectBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox screenCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox timesTXT;
        private Controls.StandardEdgedButton startBTN;
        private System.Windows.Forms.FlowLayoutPanel itemList;
        private System.Windows.Forms.Button scrollDownButton;
        private System.Windows.Forms.Button scrollUpButton;
        private System.Windows.Forms.Label screenResolutionTxt;
        private System.Windows.Forms.Button removeAllBTN;
        private System.Windows.Forms.Label label3;
    }
}

