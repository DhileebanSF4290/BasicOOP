using System;
namespace PolymorphismSquareDifferentType
{
    class Program
    {
        public static int Square(int number1, int number2)
        {
            return number1*number2;
        }
        public static float Square(float number1,float number2)
        {
            return number1*number2;
        }
        public static double Square(double number1,double number2)
        {
            return number1*number2;
        }
        public static long Square(long number1,long number2)
        {
            return number1*number2;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Square(3,3));
            Console.WriteLine(Square(3.224,3.243));
            Console.WriteLine(Square(2.76543,3.8765));
            Console.WriteLine(Square(1567,9873));
        }
    }
}
