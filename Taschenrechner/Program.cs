using System;

namespace TaschenRechner1
{
    class Rechner // HEllo
    {
        static void Main(string[] args)
        { 

            double num1 = 0;
            double num2 = 0;
            double result = 0;
            
            Console.WriteLine("Erster Taschenrechner auf C#");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Option");
            Console.WriteLine("---------------------------------------");

           
            Console.WriteLine("Enter number 1");
            num1= Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter number 2");
            num2 = Convert.ToDouble(Console.ReadLine());


           
            Console.WriteLine("Weli recheoperation wetsch");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : subtract");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"du Kalb: {num1} - {num2} = " + result);
                    break;

                default:
                    Console.WriteLine("That was not a valid option");
                    break;
            }

            

            Console.ReadKey();

        }
    }

}
