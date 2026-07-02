namespace Cinema
{
    partial class UC_UserAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserAccount));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Password = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            LoginBtn = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MadaniArabic-ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(556, 233);
            label1.Name = "label1";
            label1.Size = new Size(147, 62);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(448, 356);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("MS PGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.White;
            Password.Location = new Point(451, 429);
            Password.Name = "Password";
            Password.Size = new Size(88, 18);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(451, 454);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(448, 381);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(18, 20, 27);
            LoginBtn.FlatAppearance.BorderColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 5;
            LoginBtn.Font = new Font("MadaniArabic-ExtraBold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(571, 501);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 49);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(18, 20, 27);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MadaniArabic-ExtraBold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.InactiveCaption;
            txtUsername.Location = new Point(543, 347);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 28);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(18, 20, 27);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MadaniArabic-ExtraBold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(545, 421);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 28);
            txtPassword.TabIndex = 7;
            // 
            // UC_UserAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 20, 27);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(LoginBtn);
            Controls.Add(panel2);
            Controls.Add(Password);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UC_UserAccount";
            Size = new Size(1317, 650);
            Load += UC_UserAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label Password;
        private Panel panel1;
        private Panel panel2;
        private Button LoginBtn;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}
