using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("please insert the length of the side of the triangle");
            string s = Console.ReadLine();
            int side = int.Parse(s);
            int pirimiter = side * 3;
            Console.WriteLine("the pirimiter is " + pirimiter);

            //2.
            Console.WriteLine("please insert the length of the side of the hexagon");
            string d = Console.ReadLine();
            side = int.Parse(d);
            int numofsides = 6;
            pirimiter = side * numofsides;
            Console.WriteLine("the pirimiter of the hexagon is " + pirimiter);

            numofsides = 4;
            pirimiter = side * numofsides;
            Console.WriteLine("the pirimiter of the square is " + pirimiter);

            //3.
            Console.WriteLine("please insert the price of falafel");
            s = Console.ReadLine();
            int falafel = int.Parse(s);

            Console.WriteLine("please insert the price of drink");
            s = Console.ReadLine();
            int drink = int.Parse(s);

            int total = drink + falafel;
            Console.WriteLine("the price of falafel and drink together is " + total);

            //4.




        }

    }
}
