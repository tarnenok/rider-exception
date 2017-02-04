using System;

namespace RiderExeption
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test");
            throw new Exception();
            Console.Read();
        }
    }
}