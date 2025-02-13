//Author: Victor Flores
//Course: COMP-003A
//Faculty: Jonathon Cruz
//Purpose: Demonstrate method overload/override in C#
namespace COMP003A_LectureActivity6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //demonstrating method overloading 
            ShapeCalculator calculator = new ShapeCalculator();
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(5, 10)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5, 10, true)}");

            //demonstrating method override 
            //Creating a base class reference to a derived class object for plymorphism
            Shape myCircle = new Circle(7);
            Shape myRectangle = new Rectangle(4, 8);

            //callinng displayarea method for the circle and rectangle
            myCircle.DisplayArea();
            myRectangle.DisplayArea();
        }
    }
}
