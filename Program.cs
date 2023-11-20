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
            t.SetVisible(false);
            DrawAxes(t);
            DrawLine(t, -5, f(-5));
            t.TailDown();
            for (int x = 1 + (int)x1; x <= 5; x++)
                DrawLine(t, x, f(x));

        }
        /// <summary>
        /// y=x^2
        /// </summary>
        static double f(double x) => x * x;

        static void DrawAxes(Turtle tuti)
        {
            DrawLine(tuti, 0, 10);
            DrawLine(tuti, 0, -10);
            tuti.TailUp();
            DrawLine(tuti, -10, 0);
            tuti.TailDown();
            DrawLine(tuti, 10, 0);
            tuti.TailUp();
        }
        static void DrawLine(Turtle tur, double x2, double y2)
        {
            double angle = CalculateAngle(x1, y1, x2, y2);
            double distance = DistanceBetweenPoints(x1, y1, x2, y2);
            RotateTurtle(tur, angle);
            tur.MoveForward(distance);
            currentAngle = angle; // Update the current angle
            x1 = x2; y1 = y2; // Update the current point into x1,y1.
        }

        static double CalculateAngle(double x1, double y1, double x2, double y2)
        {
            return Math.Atan2(y2 - y1, x2 - x1) * (180 / Math.PI); //calculate angle from slope.
        }

        static double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return 10 * Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //10* for scale
        }

        static void RotateTurtle(Turtle tutu, double targetAngle)
        {
            tutu.TurnRight(currentAngle - targetAngle);
        }
    }

}