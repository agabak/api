using System.Collections.Generic;

namespace api.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; } 

        public  ICollection<Feature> Features { get; set; }      
    }
}