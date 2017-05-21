using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ConcertModel
    {
        public int ID { get; set; }
        public int OrganizerID { get; set; }
        public int PlaceID { get; set; }
        public DateTime Time { get; set; }
    }
}
