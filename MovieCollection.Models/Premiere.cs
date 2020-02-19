using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class Premiere
    {
        public DateTime PremiereDate { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
