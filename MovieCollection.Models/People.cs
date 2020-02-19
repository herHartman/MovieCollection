using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public ICollection<MoviePeople> MoviePeoples { get; set; }
    }
}
