using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEntity
{
    public class Movies
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreID { get; set; }
        public string Description { get; set; }
    }
}
