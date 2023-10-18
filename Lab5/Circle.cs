using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Circle
    {

        
        public int _radius { get; set; }
        
         

        static void GetArea(int radius) 
        {
            Console.WriteLine("Skriv in radie i cm till en cirkel så visar jag dess area");
            radius = Convert.ToInt32(Console.ReadLine());

            double area = radius * radius * Math.PI;
            Console.WriteLine(area);

        }
    }

}
