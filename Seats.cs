using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Seat
    {
        public int Number { get; set; }
        public bool IsBooked { get; set; }
        public bool IsSelected { get; set; }


        public Seat(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return "Seat " + Number + (IsBooked ? " (Booked)" : " (Available)");
        }
    }

}
