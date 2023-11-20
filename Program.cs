using System;
using Unit4.TurtleLib;

namespace ConsoleFunctionsPloting
{
    class Program
    {
        static double currentAngle = 90; //the turtle starts facing north
        static double x1 = 0, y1 = 0;

        static void Main(string[] args)
        {
            Turtle t = new Turtle();
            t.TailDown();
            t.MoveForward(50);

        }
        
    }

}