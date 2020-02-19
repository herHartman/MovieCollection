using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieCountry> MovieCountries { get; set; }
    }
}
