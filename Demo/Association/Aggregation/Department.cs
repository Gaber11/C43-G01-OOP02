using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Aggregation
{
    class Department
    {
        public int code { get; set; }
        public string name { get; set; }
        public DateOnly CreationDate { get; set; } // Composition Not nullable

    }
}
