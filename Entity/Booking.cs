using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Booking
    {
        public string BookingId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int IndentityCard { get; set; }
        public string TypeRoom { get; set; }
        public DateTime DateOfBooking { get; set; }
        public string Address { get; set; }
        public double BillAmount { get; set; }
    }
}
