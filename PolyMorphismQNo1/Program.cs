using System;
namespace PolyMorphismQNo1
{
    class Program
    {
        public static int Square(int number)
        {
            return number*number;
        }
        public static int Square(int number1,int number2)
        {
            return number1*number2;
        }
        public static int Square(int number1,int number2,int number3)
        {
            return number1*number2*number3;
        }
        public static double DifferentSquare(int number1,double number2)
        {
            return number1*number2;
        }
        public static double DifferentSquare(int number1,double number2,double number3)
        {
            return number1*number2*number3;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Square(3));
            Console.WriteLine(Square(3,3));
            Console.WriteLine(Square(3,4,5));
            Console.WriteLine(DifferentSquare(3,3.5));
            Console.WriteLine(DifferentSquare(3,3.5,4.5));

        }
    }
}