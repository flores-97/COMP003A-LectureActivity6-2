using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_LectureActivity6_2
{
    internal class Circle : Shape
    {
        //auto implement property for the radius of circle
        public double Radius { get; set; }

        /// <summary>
        /// constructor for cirle class
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double  radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// display area of circle
        /// </summary>
        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Area: {Math.PI * Radius *  Radius}");    
        }
    }
}
