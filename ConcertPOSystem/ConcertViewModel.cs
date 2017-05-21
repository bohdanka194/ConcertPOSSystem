using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertPOSystem.ViewModel
{
    public class ConcertViewModel
    {
        private Context context = new Context();
        public IEnumerable<Concert> Concerts { get; set; }
        public void GetConcerts()
        {
            Concerts = context.Concert;
        }
        public ConcertViewModel()
        {
            Concerts = new List<Concert>(context.Concert);
        }
    }
}
