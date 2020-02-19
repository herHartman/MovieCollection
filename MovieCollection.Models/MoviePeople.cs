using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class MoviePeople
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int PeopleId { get; set; }
        public People People { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
