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
        public int EntityId { get; set; }
        public IEnumerable<IEntity> Entity { get; set; }
        public IEnumerable<string> Countries { get; set; }
        public decimal Budget { get; set; }
        public decimal Dues { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public DateTime WorldPremiere { get; set; }
        public DateTime DvdRealiase { get; set; }
        public DateTime BluRatReRealise { get; set; }
        public int Rating { get; set; }
        public IEnumerable<string> Genres { get; set; }
    }
}
