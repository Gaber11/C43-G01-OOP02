using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
     class Product
    {
        public int code {  get; set; }  
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Product(string _Name)
        {
            Name= _Name;    
        }
    }
}
