using System;

namespace TaschenRechner1
{
    class Rechner
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;
            
            Console.WriteLine("Erster Taschenrechner auf C#");

            Console.WriteLine("Enter number 1");
            num1= Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();

        }
    }

}
