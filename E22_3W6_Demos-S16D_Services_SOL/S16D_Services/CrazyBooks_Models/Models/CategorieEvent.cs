using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CategorieEvent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<CalendarEvent> Events { get; set; }
    }
}
