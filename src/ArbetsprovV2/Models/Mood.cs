using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArbetsprovV2.Models
{
    public class Mood
    {
        public Mood(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
