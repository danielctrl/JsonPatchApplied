using System.Collections.Generic;

namespace WebApi.Models
{
    public class FooItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Check { get; set; }

        public IEnumerable<FooSubItem> FooSubItems { get; set; }
    }
}