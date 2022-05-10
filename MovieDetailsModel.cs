using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MoviesDB
{
    public class MovieDetailsModel : Form 
    {
        
        public string title { get; set; }
        public string genres { get; set; }
        public int id { get; set; }
        public string poster { get; set; }
        public string desc { get; set; }
        public string release_date { get; set; }
        public string adjara_url { get; set; }
        public string vid_url { get; set; }
        public dynamic seasonData { get; set; }

    }
}
