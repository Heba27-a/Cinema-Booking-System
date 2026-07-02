using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cinema
{
    public partial class BookingForm : UserControl
    {
        private Movie movie;        
        private Form1 mainForm;      
        public BookingForm(Movie selectedMovie, Form1 form)
        {
            InitializeComponent();
            movie = selectedMovie;  
            mainForm = form;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            labelMovieTitle.Text = movie.Title;
            PictureBox[] seatBoxes = { Seat1,Seat2,Seat3,Seat4,Seat5,Seat6,Seat7,Seat8,Seat9,Seat10,
                Seat11,Seat12,Seat13,Seat14,Seat15,Seat16,Seat17,Seat18,Seat19,Seat20 };  

            for (int i = 0; i < seatBoxes.Length; i++)
            {
                var pb = seatBoxes[i];
                var seat = movie.Seats.ElementAt(i);
                pb.Tag = seat;
                pb.Image = seat.IsBooked ? Properties.Resources.ChairBooked : Properties.Resources.EmptyChair;
                pb.Click += Seat_Click;
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Seat seat = pic.Tag as Seat;

            if (seat.IsBooked)
            {
                MessageBox.Show($"Seat {seat.Number} is already booked!");
                pic.Image = Properties.Resources.ChairBooked;
                return;
            }

            seat.IsSelected = !seat.IsSelected;

            if (seat.IsSelected)
            {
                pic.Image = Properties.Resources.ChairSelected;
            }
            else
            {
                pic.Image = Properties.Resources.EmptyChair;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var currentUserSelectedSeats = movie.Seats.Where(s => s.IsSelected && !s.IsBooked).ToList();

            if (currentUserSelectedSeats.Count == 0)
            {
                if (movie.Seats.All(s => s.IsBooked))
                {
                    DialogResult wait = MessageBox.Show(
                "All seats are booked!\nWould you like to join the waiting list?",
                "Waiting List",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                    if (wait == DialogResult.Yes)
                    {
                        string userName = mainForm.CurrentUser;
                        movie.WaitingList.AddToWaitingList(userName);
                        MessageBox.Show($"You have been added to the waiting list for {movie.Title} movie.");
                    }
                }
                else
                {
                    MessageBox.Show("You have not selected any seats!");
                }
                return;
            }

            DialogResult result = MessageBox.Show(
             "Are you sure you want to confirm your booking?",
             "Confirm Booking",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            // لما بيتحجز المقعد بتتحدث اللست
            foreach (var seat in currentUserSelectedSeats)
            {
                seat.IsBooked = true;
                seat.IsSelected = false;
            }

            UC_Reservation reservationForm = new UC_Reservation(movie, currentUserSelectedSeats, mainForm.CurrentUser);
            Form1 parentForm = this.ParentForm as Form1;
            if (parentForm != null)
                parentForm.LoadPage(reservationForm);

            currentUserSelectedSeats = new List<Seat>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.ParentForm as Form1;

            if (parentForm != null)
            {
                UC_Movies moviesPage = new UC_Movies(parentForm.movieManager.Movies, parentForm);
                parentForm.LoadPage(moviesPage);
            }

        }
    }
}