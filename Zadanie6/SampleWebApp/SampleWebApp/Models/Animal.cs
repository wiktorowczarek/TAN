using System.ComponentModel.DataAnnotations;

namespace SampleWebApp.Models
{
    public class Animal
    {
        public int IdAnimal { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Area { get; set; }
    }
}