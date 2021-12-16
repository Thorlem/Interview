using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intern.Models
{
    public class Country
    {
        public Country(string Id,int Score, string Name, List<string> neighbours)
        {
            this.Id = Id;
            this.Score = Score;
            this.Name = Name;
            this.Neighbours = neighbours;
        }

        public string Id { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }
        public List<String> Neighbours { get; set; }
    }
}
