namespace XRails
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.xRails_RightPanel1 = new XRails.XRails_RightPanel();
            this.xRails_TextBox2 = new XRails.XRails_TextBox();
            this.xRails_TextBox1 = new XRails.XRails_TextBox();
            this.xRails_LinkLabel1 = new XRails.XRails_LinkLabel();
            this.xRails_Label2 = new XRails.XRails_Label();
            this.xRails_Label1 = new XRails.XRails_Label();
            this.TitleLabel_LoginTo = new XRails.XRails_TitleLabel();
            this.Button_Login = new XRails.XRails_Button();
            this.Label_LoggingIn = new XRails.XRails_Label();
            this.xRails_LeftPanel1 = new XRails.XRails_LeftPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xRails_TopLeftBox1 = new XRails.XRails_TopLeftBox();
            this.TitleLabel_Welcome = new XRails.XRails_TitleLabel();
            this.xRails_RightPanel1.SuspendLayout();
            this.xRails_LeftPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Custom;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // xRails_RightPanel1
            // 
            this.xRails_RightPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.xRails_RightPanel1.Controls.Add(this.xRails_TextBox2);
            this.xRails_RightPanel1.Controls.Add(this.xRails_TextBox1);
            this.xRails_RightPanel1.Controls.Add(this.xRails_LinkLabel1);
            this.xRails_RightPanel1.Controls.Add(this.xRails_Label2);
            this.xRails_RightPanel1.Controls.Add(this.xRails_Label1);
            this.xRails_RightPanel1.Controls.Add(this.TitleLabel_LoginTo);
            this.xRails_RightPanel1.Controls.Add(this.Button_Login);
            this.xRails_RightPanel1.Controls.Add(this.Label_LoggingIn);
            this.xRails_RightPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.xRails_RightPanel1, AnimatorNS.DecorationType.None);
            this.xRails_RightPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xRails_RightPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.xRails_RightPanel1.Location = new System.Drawing.Point(335, 0);
            this.xRails_RightPanel1.Name = "xRails_RightPanel1";
            this.xRails_RightPanel1.Size = new System.Drawing.Size(337, 480);
            this.xRails_RightPanel1.TabIndex = 1;
            // 
            // xRails_TextBox2
            // 
            this.xRails_TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.xRails_TextBox2.ColorBordersOnEnter = false;
            this.animator1.SetDecoration(this.xRails_TextBox2, AnimatorNS.DecorationType.None);
            this.xRails_TextBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xRails_TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.xRails_TextBox2.Image = ((System.Drawing.Image)(resources.GetObject("xRails_TextBox2.Image")));
            this.xRails_TextBox2.Location = new System.Drawing.Point(-1, 247);
            this.xRails_TextBox2.MaxLength = 32767;
            this.xRails_TextBox2.Multiline = false;
            this.xRails_TextBox2.Name = "xRails_TextBox2";
            this.xRails_TextBox2.ReadOnly = false;
            this.xRails_TextBox2.ShortcutsEnabled = true;
            this.xRails_TextBox2.ShowBottomBorder = true;
            this.xRails_TextBox2.ShowTopBorder = false;
            this.xRails_TextBox2.Size = new System.Drawing.Size(339, 50);
            this.xRails_TextBox2.TabIndex = 6;
            this.xRails_TextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.xRails_TextBox2.UseSystemPasswordChar = true;
            this.xRails_TextBox2.Watermark = "Password";
            this.xRails_TextBox2.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // xRails_TextBox1
            // 
            this.xRails_TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.xRails_TextBox1.ColorBordersOnEnter = false;
            this.animator1.SetDecoration(this.xRails_TextBox1, AnimatorNS.DecorationType.None);
            this.xRails_TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xRails_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.xRails_TextBox1.Image = ((System.Drawing.Image)(resources.GetObject("xRails_TextBox1.Image")));
            this.xRails_TextBox1.Location = new System.Drawing.Point(-1, 197);
            this.xRails_TextBox1.MaxLength = 32767;
            this.xRails_TextBox1.Multiline = false;
            this.xRails_TextBox1.Name = "xRails_TextBox1";
            this.xRails_TextBox1.ReadOnly = false;
            this.xRails_TextBox1.ShortcutsEnabled = true;
            this.xRails_TextBox1.ShowBottomBorder = false;
            this.xRails_TextBox1.ShowTopBorder = true;
            this.xRails_TextBox1.Size = new System.Drawing.Size(339, 50);
            this.xRails_TextBox1.TabIndex = 5;
            this.xRails_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.xRails_TextBox1.UseSystemPasswordChar = false;
            this.xRails_TextBox1.Watermark = "Username or Email";
            this.xRails_TextBox1.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // xRails_LinkLabel1
            // 
            this.xRails_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.xRails_LinkLabel1.AutoSize = true;
            this.xRails_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xRails_LinkLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.xRails_LinkLabel1, AnimatorNS.DecorationType.None);
            this.xRails_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xRails_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.xRails_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.xRails_LinkLabel1.Location = new System.Drawing.Point(200, 443);
            this.xRails_LinkLabel1.Name = "xRails_LinkLabel1";
            this.xRails_LinkLabel1.Size = new System.Drawing.Size(91, 15);
            this.xRails_LinkLabel1.TabIndex = 4;
            this.xRails_LinkLabel1.TabStop = true;
            this.xRails_LinkLabel1.Text = "admin@xrails.io";
            this.xRails_LinkLabel1.Visible = false;
            this.xRails_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // xRails_Label2
            // 
            this.xRails_Label2.AutoSize = true;
            this.xRails_Label2.BackColor = System.Drawing.Color.Transparent;
            this.xRails_Label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.xRails_Label2, AnimatorNS.DecorationType.None);
            this.xRails_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xRails_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.xRails_Label2.Location = new System.Drawing.Point(25, 428);
            this.xRails_Label2.Name = "xRails_Label2";
            this.xRails_Label2.Size = new System.Drawing.Size(262, 30);
            this.xRails_Label2.TabIndex = 3;
            this.xRails_Label2.Text = "To obtain access to this app or for any questions\r\nabout its use, submit an email" +
    " to";
            this.xRails_Label2.Visible = false;
            // 
            // xRails_Label1
            // 
            this.xRails_Label1.AutoSize = true;
            this.xRails_Label1.BackColor = System.Drawing.Color.Transparent;
            this.xRails_Label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.xRails_Label1, AnimatorNS.DecorationType.None);
            this.xRails_Label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xRails_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.xRails_Label1.Location = new System.Drawing.Point(25, 410);
            this.xRails_Label1.Name = "xRails_Label1";
            this.xRails_Label1.Size = new System.Drawing.Size(52, 15);
            this.xRails_Label1.TabIndex = 2;
            this.xRails_Label1.Text = "Support";
            this.xRails_Label1.Visible = false;
            // 
            // TitleLabel_LoginTo
            // 
            this.TitleLabel_LoginTo.AutoSize = true;
            this.TitleLabel_LoginTo.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel_LoginTo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.TitleLabel_LoginTo, AnimatorNS.DecorationType.None);
            this.TitleLabel_LoginTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.TitleLabel_LoginTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.TitleLabel_LoginTo.Location = new System.Drawing.Point(12, 143);
            this.TitleLabel_LoginTo.Name = "TitleLabel_LoginTo";
            this.TitleLabel_LoginTo.Side = XRails.XRails_TitleLabel.PanelSide.RightPanel;
            this.TitleLabel_LoginTo.Size = new System.Drawing.Size(298, 40);
            this.TitleLabel_LoginTo.TabIndex = 1;
            this.TitleLabel_LoginTo.Text = "Login to your account";
            this.TitleLabel_LoginTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel_LoginTo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.TitleLabel_LoginTo.UseCompatibleTextRendering = true;
            this.TitleLabel_LoginTo.Visible = false;
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.Button_Login, AnimatorNS.DecorationType.None);
            this.Button_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Login.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Button_Login.Location = new System.Drawing.Point(-4, 317);
            this.Button_Login.MinimumSize = new System.Drawing.Size(144, 47);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Radius = 20;
            this.Button_Login.Size = new System.Drawing.Size(144, 47);
            this.Button_Login.TabIndex = 7;
            this.Button_Login.Text = "LOGIN";
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_LoggingIn
            // 
            this.Label_LoggingIn.BackColor = System.Drawing.Color.Transparent;
            this.Label_LoggingIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.Label_LoggingIn, AnimatorNS.DecorationType.None);
            this.Label_LoggingIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label_LoggingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.Label_LoggingIn.Image = ((System.Drawing.Image)(resources.GetObject("Label_LoggingIn.Image")));
            this.Label_LoggingIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_LoggingIn.Location = new System.Drawing.Point(18, 329);
            this.Label_LoggingIn.Name = "Label_LoggingIn";
            this.Label_LoggingIn.Size = new System.Drawing.Size(104, 25);
            this.Label_LoggingIn.TabIndex = 8;
            this.Label_LoggingIn.Text = "      Logging in...";
            this.Label_LoggingIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_LoggingIn.Visible = false;
            // 
            // xRails_LeftPanel1
            // 
            this.xRails_LeftPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.xRails_LeftPanel1.Controls.Add(this.pictureBox1);
            this.xRails_LeftPanel1.Controls.Add(this.xRails_TopLeftBox1);
            this.xRails_LeftPanel1.Controls.Add(this.TitleLabel_Welcome);
            this.xRails_LeftPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.xRails_LeftPanel1, AnimatorNS.DecorationType.None);
            this.xRails_LeftPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xRails_LeftPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.xRails_LeftPanel1.Location = new System.Drawing.Point(0, 0);
            this.xRails_LeftPanel1.Name = "xRails_LeftPanel1";
            this.xRails_LeftPanel1.Size = new System.Drawing.Size(335, 480);
            this.xRails_LeftPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(98)))));
            this.animator1.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // xRails_TopLeftBox1
            // 
            this.xRails_TopLeftBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(102)))), ((int)(((byte)(98)))));
            this.animator1.SetDecoration(this.xRails_TopLeftBox1, AnimatorNS.DecorationType.None);
            this.xRails_TopLeftBox1.Location = new System.Drawing.Point(25, 0);
            this.xRails_TopLeftBox1.MinimumSize = new System.Drawing.Size(100, 42);
            this.xRails_TopLeftBox1.Name = "xRails_TopLeftBox1";
            this.xRails_TopLeftBox1.Size = new System.Drawing.Size(310, 146);
            this.xRails_TopLeftBox1.TabIndex = 1;
            this.xRails_TopLeftBox1.Text = "xRails_TopLeftBox1";
            // 
            // TitleLabel_Welcome
            // 
            this.TitleLabel_Welcome.AutoSize = true;
            this.TitleLabel_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel_Welcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.animator1.SetDecoration(this.TitleLabel_Welcome, AnimatorNS.DecorationType.None);
            this.TitleLabel_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.TitleLabel_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TitleLabel_Welcome.Location = new System.Drawing.Point(25, 221);
            this.TitleLabel_Welcome.Name = "TitleLabel_Welcome";
            this.TitleLabel_Welcome.Side = XRails.XRails_TitleLabel.PanelSide.LeftPanel;
            this.TitleLabel_Welcome.Size = new System.Drawing.Size(284, 74);
            this.TitleLabel_Welcome.TabIndex = 0;
            this.TitleLabel_Welcome.Text = "Welcome to the\r\nXRails access portal";
            this.TitleLabel_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel_Welcome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.TitleLabel_Welcome.UseCompatibleTextRendering = true;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 480);
            this.Controls.Add(this.xRails_RightPanel1);
            this.Controls.Add(this.xRails_LeftPanel1);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XRails";
            this.Shown += new System.EventHandler(this.Form_Login_Shown);
            this.xRails_RightPanel1.ResumeLayout(false);
            this.xRails_RightPanel1.PerformLayout();
            this.xRails_LeftPanel1.ResumeLayout(false);
            this.xRails_LeftPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XRails_LeftPanel xRails_LeftPanel1;
        private XRails_RightPanel xRails_RightPanel1;
        private XRails_TitleLabel TitleLabel_Welcome;
        private XRails_TitleLabel TitleLabel_LoginTo;
        private XRails_Label xRails_Label1;
        private XRails_Label xRails_Label2;
        private XRails_LinkLabel xRails_LinkLabel1;
        private XRails_TopLeftBox xRails_TopLeftBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AnimatorNS.Animator animator1;
        private XRails_TextBox xRails_TextBox2;
        private XRails_TextBox xRails_TextBox1;
        private XRails_Button Button_Login;
        private XRails_Label Label_LoggingIn;

    }
}