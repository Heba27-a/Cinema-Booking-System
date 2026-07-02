using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class UC_Movies : UserControl
    {
        private List<Movie> movies;
        private Movie selectedMovie = null;
        private Form1 mainForm;

        public UC_Movies(List<Movie> moviesList, Form1 form)
        {
            InitializeComponent();
            movies = moviesList;
            mainForm = form;
            GroupBoxDetails.Visible = false;
        }

    private void UC_Movies_Load(object sender, EventArgs e)
        {
            label1.Text = movies[0].Title;
            label2.Text = movies[1].Title;
            label3.Text = movies[2].Title;
            label4.Text = movies[3].Title;
            label5.Text = movies[4].Title;
            label6.Text = movies[5].Title;

            pictureBox1.Image = Properties.Resources.Interstellar;
            pictureBox2.Image = Properties.Resources.Incerption;
            pictureBox3.Image = Properties.Resources.The_Dark_Knight;
            pictureBox4.Image = Properties.Resources.Avatar;
            pictureBox5.Image = Properties.Resources.Dune;
            pictureBox6.Image = Properties.Resources.Matrix;
        }
        private void ShowMovieDetails(Movie movie)
        {
            if (movie == null) return;

            MovieInfo.Text = movie.MovieInfo();
            GroupBoxDetails.Visible = true;
            selectedMovie = movie;

            switch (movie.Title)
            {
                case "Interstellar":
                    pictureBoxDetails.Image = Properties.Resources.Interstellar;
                    break;
                case "Inception":
                    pictureBoxDetails.Image = Properties.Resources.Incerption;
                    break;
                case "The Dark Knight":
                    pictureBoxDetails.Image = Properties.Resources.The_Dark_Knight;
                    break;
                case "Avatar":
                    pictureBoxDetails.Image = Properties.Resources.Avatar;
                    break;
                case "Dune":
                    pictureBoxDetails.Image = Properties.Resources.Dune;
                    break;
                case "Matrix":
                    pictureBoxDetails.Image = Properties.Resources.Matrix;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectedMovie = movies[0];
            ShowMovieDetails(selectedMovie);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedMovie = movies[1];
            ShowMovieDetails(selectedMovie);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedMovie = movies[2];
            ShowMovieDetails(selectedMovie);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectedMovie = movies[3];
            ShowMovieDetails(selectedMovie);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectedMovie = movies[4];
            ShowMovieDetails(selectedMovie);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectedMovie = movies[5];
            ShowMovieDetails(selectedMovie);
        }
        private void btnBuyTickets_Click(object sender, EventArgs e)
        {
            if (selectedMovie != null)
            {
                mainForm.LoadPage(new BookingForm(selectedMovie, mainForm));
            }
            else
            {
                MessageBox.Show("Please select a movie first!");
            }
        }
    }
}
