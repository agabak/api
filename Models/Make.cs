using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace api.Models
{
    public class Make
    {
        public Make() => new Collection<Model>();
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }
        
    }
}