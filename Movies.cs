using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace MoviesDB
{
    public class Meta
    {
        public Pagination pagination { get; set; }
    }
    public class Movie
    {
        public Data[] data { get; set; }

        public Meta meta { get; set; }
    }
}
