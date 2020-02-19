using System;
using System.Collections.Generic;

namespace MovieCollection.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Tagline { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public decimal Budget { get; set; }
        public decimal Dues { get; set; }
        public string WorldPremiere { get; set; }
        public string DvdRealiase { get; set; }
        public string BluRayRealise { get; set; }
        public int Rating { get; set; }
        public ICollection<MoviePeople> MoviePeoples { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieCountry> MovieCountries { get; set; }
    }
}
