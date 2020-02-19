using MovieCollection.Database;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Application.MovieAdmin
{
    public class CreateMovie
    {
        private ApplicationDbContext _ctx;

        public CreateMovie(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {

            await _ctx.SaveChangesAsync();
            return new Response();
        }

        public class Response
        {
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

        public class Request
        {
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
}
