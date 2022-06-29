using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }


        [ForeignKey("CategorieEvent_Id")]
        public int CategorieEvent_Id { get; set; }

        public CategorieEvent Categorie { get; set; }
    }
}
