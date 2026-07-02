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
    public partial class UC_Reservation : UserControl
    {
        private Movie movie;
        private List<Seat> bookedSeats;
        private string userName;
        public UC_Reservation(Movie selectedMovie, List<Seat> seats, string user)
        {
            InitializeComponent();
            movie = selectedMovie;
            bookedSeats = seats;
            userName = user;
        }

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            labelUsername.Text = $"User: {userName}";
            labelMovieTitle.Text = $"{movie.Title}";
            string seatNumbers = string.Join(", ", bookedSeats.Select(s => s.Number));
            labelBookedSeats.Text = $"Booked Seats: {seatNumbers}";
            labelMovieTime.Text = "At: 10:30 PM";

            switch (movie.Title)
            {
                case "Interstellar":
                    MoviePoster.Image = Properties.Resources.Interstellar;
                    break;
                case "Inception":
                    MoviePoster.Image = Properties.Resources.Incerption;
                    break;
                case "The Dark Knight":
                    MoviePoster.Image = Properties.Resources.The_Dark_Knight;
                    break;
                case "Avatar":
                    MoviePoster.Image = Properties.Resources.Avatar;
                    break;
                case "Dune":
                    MoviePoster.Image = Properties.Resources.Dune;
                    break;
                case "Matrix":
                    MoviePoster.Image = Properties.Resources.Matrix;
                    break;
            }
        }

        private void btnBackToMovies_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.ParentForm as Form1;
            if (mainForm != null)
            {
                UC_Movies moviesPage = new UC_Movies(mainForm.movieManager.Movies, mainForm);
                mainForm.LoadPage(moviesPage);
            }
        }
    }
}
