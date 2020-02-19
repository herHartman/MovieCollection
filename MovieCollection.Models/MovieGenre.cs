using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class MovieGenre
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
