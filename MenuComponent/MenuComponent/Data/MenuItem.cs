using System.Collections.Generic;

namespace MenuComponent.Data
{
    public class MenuItem
    {
        public string Key { get; set; }

        public string Value { get; set; }
               
        public IEnumerable<MenuItem> Children { get; set; }
    }
}
