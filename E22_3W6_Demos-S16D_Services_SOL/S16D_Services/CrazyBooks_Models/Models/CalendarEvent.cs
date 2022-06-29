using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Categories Categories { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
