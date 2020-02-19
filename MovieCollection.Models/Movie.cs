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
        public int Time { get; set; }
        public DateTime DvdRealiase { get; set; }
        public DateTime BluRayRealise { get; set; }
        public int Rating { get; set; }
        public int PG { get; set; }
        public ICollection<MoviePeople> MoviePeoples { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieCountry> MovieCountries { get; set; }
        public ICollection<Premiere> Premieres { get; set; }
    }
}
