using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TicketModel
    {
        public int ID { get; set; }
        public int ConcertID { get; set; }
        public int? UserID { get; set; }
        public int Price { get; set; }
        public int Row { get; set; }
        public int Seat { get; set; }
        
       
    }
}
