namespace loginatubaw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            CheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            TxtUser = new Guna.UI2.WinForms.Guna2TextBox();
            TxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CheckBox
            // 
            CheckBox.AutoSize = true;
            CheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            CheckBox.CheckedState.BorderRadius = 0;
            CheckBox.CheckedState.BorderThickness = 0;
            CheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            CheckBox.Location = new Point(12, 316);
            CheckBox.Name = "CheckBox";
            CheckBox.Size = new Size(108, 19);
            CheckBox.TabIndex = 1;
            CheckBox.Text = "Show Password";
            CheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            CheckBox.UncheckedState.BorderRadius = 0;
            CheckBox.UncheckedState.BorderThickness = 0;
            CheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            CheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // TxtUser
            // 
            TxtUser.BorderRadius = 10;
            TxtUser.CustomizableEdges = customizableEdges1;
            TxtUser.DefaultText = "";
            TxtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtUser.Font = new Font("Segoe UI", 9F);
            TxtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtUser.Location = new Point(12, 190);
            TxtUser.Name = "TxtUser";
            TxtUser.PasswordChar = '\0';
            TxtUser.PlaceholderText = "USERNAME";
            TxtUser.SelectedText = "";
            TxtUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxtUser.Size = new Size(254, 57);
            TxtUser.TabIndex = 2;
            // 
            // TxtPass
            // 
            TxtPass.BorderRadius = 10;
            TxtPass.CustomizableEdges = customizableEdges3;
            TxtPass.DefaultText = "";
            TxtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtPass.Font = new Font("Segoe UI", 9F);
            TxtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtPass.Location = new Point(12, 253);
            TxtPass.Name = "TxtPass";
            TxtPass.PasswordChar = '\0';
            TxtPass.PlaceholderText = "PASSWORD";
            TxtPass.SelectedText = "";
            TxtPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TxtPass.Size = new Size(254, 57);
            TxtPass.TabIndex = 3;
            // 
            // BtnLogin
            // 
            BtnLogin.BorderRadius = 10;
            BtnLogin.CustomizableEdges = customizableEdges5;
            BtnLogin.DisabledState.BorderColor = Color.DarkGray;
            BtnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnLogin.FillColor = Color.Green;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(12, 341);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnLogin.Size = new Size(254, 57);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "LOGIN";
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 162);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(278, 409);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPass);
            Controls.Add(TxtUser);
            Controls.Add(CheckBox);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBox;
        private Guna.UI2.WinForms.Guna2TextBox TxtUser;
        private Guna.UI2.WinForms.Guna2TextBox TxtPass;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Label label1;
    }
}
