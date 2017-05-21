using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    class ConcertRepository
    {
        private Context context;
        public IEnumerable<Concert> Concerts => context.Concert;
        public ConcertRepository(Context context1)
        {
            context = context1;
        }
    }
}
