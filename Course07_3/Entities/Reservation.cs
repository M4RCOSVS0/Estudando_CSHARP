using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course07_3.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan durantion = CheckOut.Subtract(CheckIn);
            return (int)durantion.TotalDays;
        }

        public void UpdadeDates(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyy")+", check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
}
