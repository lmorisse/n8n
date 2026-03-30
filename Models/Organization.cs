using System.Collections.Generic;

namespace WebApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}