using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A_LectureActivity6_2
{
    internal class Shape
    {
        /// <summary>
        ///represents a base class for geometric shapes 
        /// </summary>
        public virtual void DisplayArea()
        {
            Console.WriteLine("Calculating area of a shape.");
        }
    }
}
