using System;

namespace ConsoleFunctionsPloting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 7; x++)
            {
                Console.SetCursorPosition(x, (int)f(x));
                Console.Write("*");
                if (x > 2) Console.Write($"({x},{f(x)})");

                Console.SetCursorPosition(x, (int)g(x));
                Console.Write(".");
                if (x > 2) Console.Write($"({x},{g(x)})");
            }
            Console.ReadLine();
        }

        // באופן חריג רק היום מרשה לפונקציה להתחיל באות קטנה
        static double g(double x)
        {
            double k = 3;
            return k * f(x - 1) - 3;
        }
        static double f(double x)
        {
            return ((x - 3) * (x - 3) + 3);
        }
    }

}
