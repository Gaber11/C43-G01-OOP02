using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inhertance
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }

        #endregion
        public Parent()
        {
            
        }
        #region Constructor

        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion
        
        #region Methods

        public int Product()
        {

            return X * Y;
        }
        public override string ToString()
        {
            return $"X= {X}\nY= {Y}";
        } 
        #endregion


    }
      

    
}
