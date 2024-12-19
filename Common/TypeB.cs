using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB()
        {
           // TypeA typeA = new TypeA();
            //typeA.X = 10;//invalid inaccessable
            //  typeA.Y = 5; //valid -->internal &&the object is declared in the same project
            typeA.Z = 6; // valid --> public

        }
    }
}
