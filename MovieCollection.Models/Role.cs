using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MoviePeople> MoviePeoples { get; set; }
    }
}
