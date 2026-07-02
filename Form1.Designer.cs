namespace Cinema
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
            LogIn = new Label();
            panelContainer = new Panel();
            PanelText = new Label();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.BackColor = SystemColors.ActiveCaptionText;
            LogIn.Font = new Font("identify demo", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogIn.ForeColor = Color.LightGreen;
            LogIn.Location = new Point(258, 26);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(0, 82);
            LogIn.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 39);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1364, 654);
            panelContainer.TabIndex = 4;
            // 
            // PanelText
            // 
            PanelText.AutoSize = true;
            PanelText.Font = new Font("Nahdi", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelText.ForeColor = Color.Black;
            PanelText.Location = new Point(7, 12);
            PanelText.Name = "PanelText";
            PanelText.Size = new Size(109, 24);
            PanelText.TabIndex = 3;
            PanelText.Text = "MH Cinema";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(PanelText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 44);
            panel1.TabIndex = 1;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(224, 224, 224);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1225, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 20, 27);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1364, 693);
            Controls.Add(panel1);
            Controls.Add(LogIn);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogIn;
        private Panel panelContainer;
        private Label PanelText;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}
