using System;
using System.Runtime.Remoting.Channels;

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
            Console.WriteLine("please insert the price of shirt");
            s = Console.ReadLine();
            int shirt = int.Parse(s);
            Console.WriteLine("please insert the number of shirts");
            s = Console.ReadLine();
            int num = int.Parse(s);
            int tosefet = 2;
            int price = num * (tosefet + shirt);
            Console.WriteLine("the total price of shirts with labels will be " + price);

            //5.
            //1,4 or 2,3 

            //6.
            //      a    b    c
            //1.    1    2    0
            //2.    6    2    0
            //3.    6    24   0
            //4.    6
            //5.   24
            //6.    0

            //7.
            int a = 3;
            int b = 4;
            int c = b;
            Console.WriteLine("before algo " + a + " " + b);
            b = a;
            a = c;
            Console.WriteLine("after algo " + a + " " + b);

            //8.
            Console.WriteLine("please insert a two digit number");
            s = Console.ReadLine();
            num = int.Parse(s);
            int tens = num / 10;
            int units = num % 10;

            Console.WriteLine(10 * units + tens);


            //9.
            Console.WriteLine("please insert a three digit number");
            num = int.Parse(Console.ReadLine());
            int hundreds = num / 100;
            tens = num / 10;
            tens = tens % 10;
            units = num % 10;

            Console.WriteLine(100 * units + 10 * tens + hundreds);

            //error
        }

    }
}
