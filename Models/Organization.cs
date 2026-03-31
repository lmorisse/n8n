using System.Collections.Generic;

namespace YourNamespace.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}