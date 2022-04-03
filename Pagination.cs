using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDB
{
    public class Pagination
    {
        public int total_pages { get; set; }
        public int per_page { get; set; }
        public int count { get; set; }
        public int total { get; set; }
    }
}
