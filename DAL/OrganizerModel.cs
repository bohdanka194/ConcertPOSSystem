using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrganizerModel
    {
        public int ID { get; set; }
        public int Login { get; set; }
        public int OrganizerName { get; set; }
        public List<ConcertModel> Concerts { get; set; }
        
    }
}
