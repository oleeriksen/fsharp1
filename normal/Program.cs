using System;

namespace normal
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.WriteLine(new Intro().SumPos2(new int[0]));
            Console.WriteLine(new Intro().SumPos(new int[] { 1, 3, 4, -3, -7, 0 }));
        }
    }
}
