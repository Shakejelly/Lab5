using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Circle
    {
        
        public int Radius { get; set; }
        
        

        public double GetArea(int radius) 
        {
            
            return radius * radius * Math.PI;

        }
    }

}
