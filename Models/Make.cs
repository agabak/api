using System.Collections.Generic;

namespace api.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }
        
    }
}