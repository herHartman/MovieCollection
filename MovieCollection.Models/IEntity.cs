using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Models
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
    }
}
