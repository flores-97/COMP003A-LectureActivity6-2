using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_LectureActivity6_2
{
    internal class Rectangle : Shape
    {
        // auto implemented properties for lenght and width 
        public double Length { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// constructor for rectangle
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        public Rectangle (double length, double height)
        {
            Length = length;
            Height = height;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Rectangle Area: {Length * Height}");
        }
    }
}
