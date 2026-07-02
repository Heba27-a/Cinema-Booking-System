namespace Cinema
{
    partial class UC_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reservation));
            pictureBox1 = new PictureBox();
            MoviePoster = new PictureBox();
            labelMovieTitle = new Label();
            labelBookedSeats = new Label();
            labelMovieTime = new Label();
            labelUsername = new Label();
            btnBackToMovies = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MoviePoster).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(751, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MoviePoster
            // 
            MoviePoster.BackColor = Color.White;
            MoviePoster.Location = new Point(435, 225);
            MoviePoster.Name = "MoviePoster";
            MoviePoster.Size = new Size(110, 183);
            MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            MoviePoster.TabIndex = 1;
            MoviePoster.TabStop = false;
            // 
            // labelMovieTitle
            // 
            labelMovieTitle.AutoSize = true;
            labelMovieTitle.BackColor = Color.WhiteSmoke;
            labelMovieTitle.Font = new Font("Lucida Calligraphy", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMovieTitle.ForeColor = Color.FromArgb(18, 20, 27);
            labelMovieTitle.Location = new Point(571, 248);
            labelMovieTitle.Name = "labelMovieTitle";
            labelMovieTitle.Size = new Size(227, 36);
            labelMovieTitle.TabIndex = 23;
            labelMovieTitle.Text = "Movie Name: ";
            // 
            // labelBookedSeats
            // 
            labelBookedSeats.AutoSize = true;
            labelBookedSeats.BackColor = Color.WhiteSmoke;
            labelBookedSeats.Font = new Font("MadaniArabic-ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBookedSeats.ForeColor = Color.FromArgb(18, 20, 27);
            labelBookedSeats.Location = new Point(573, 313);
            labelBookedSeats.Name = "labelBookedSeats";
            labelBookedSeats.Size = new Size(94, 31);
            labelBookedSeats.TabIndex = 24;
            labelBookedSeats.Text = "Seat no.";
            labelBookedSeats.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelMovieTime
            // 
            labelMovieTime.AutoSize = true;
            labelMovieTime.BackColor = Color.WhiteSmoke;
            labelMovieTime.Font = new Font("MadaniArabic-ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMovieTime.ForeColor = Color.FromArgb(18, 20, 27);
            labelMovieTime.Location = new Point(573, 344);
            labelMovieTime.Name = "labelMovieTime";
            labelMovieTime.Size = new Size(68, 31);
            labelMovieTime.TabIndex = 25;
            labelMovieTime.Text = "Time:";
            labelMovieTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.WhiteSmoke;
            labelUsername.Font = new Font("MadaniArabic-ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.FromArgb(18, 20, 27);
            labelUsername.Location = new Point(573, 282);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(115, 31);
            labelUsername.TabIndex = 26;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBackToMovies
            // 
            btnBackToMovies.BackColor = Color.FromArgb(18, 20, 27);
            btnBackToMovies.FlatAppearance.BorderSize = 0;
            btnBackToMovies.FlatStyle = FlatStyle.Popup;
            btnBackToMovies.Font = new Font("MS PGothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            btnBackToMovies.ForeColor = Color.White;
            btnBackToMovies.Location = new Point(499, 461);
            btnBackToMovies.Name = "btnBackToMovies";
            btnBackToMovies.Size = new Size(326, 49);
            btnBackToMovies.TabIndex = 28;
            btnBackToMovies.Text = "back to available movies page";
            btnBackToMovies.UseVisualStyleBackColor = false;
            btnBackToMovies.Click += btnBackToMovies_Click;
            // 
            // UC_Reservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 20, 27);
            Controls.Add(btnBackToMovies);
            Controls.Add(labelUsername);
            Controls.Add(labelMovieTime);
            Controls.Add(labelBookedSeats);
            Controls.Add(labelMovieTitle);
            Controls.Add(MoviePoster);
            Controls.Add(pictureBox1);
            Name = "UC_Reservation";
            Size = new Size(1317, 654);
            Load += UC_Reservation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox MoviePoster;
        private Label labelMovieTitle;
        private Label labelBookedSeats;
        private Label labelMovieTime;
        private Label labelUsername;
        private Button btnBackToMovies;
    }
}
