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
        public string ZodiacSign { get; set; }
        public float Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public ICollection<MoviePeople> MoviePeoples { get; set; }
    }
}
