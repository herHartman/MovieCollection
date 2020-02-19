using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class MovieCountry
    {
        public int MovieId { get; set; }
        public int CountryId { get; set; }
        public Movie Movie { get; set; }
        public Country Country { get; set; }
    }
}
