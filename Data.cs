using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDB
{
    public class Data
    {
        public int id { get; set; }
        public int duration { get; set; }
        public dynamic seasons { get; set; }
        public bool isTvShow { get; set; }
        public string releaseDate { get; set; }
        public int year { get; set; }
        public dynamic rating { get; set; }
        public int watchCount { get; set; }
        public dynamic posters { get; set; }
        public string secondaryDescription { get; set; }
        public dynamic genres { get; set; }
        public dynamic covers { get; set; }
        public string secondaryName { get; set; }
        public string primaryName { get; set; }
        public bool adult { get; set; }
        public string adjaraId { get; set; }
        public dynamic plot { get; set; }
    }
}
