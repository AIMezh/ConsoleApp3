using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0;
            var ordinary = new Ordinary();
            var advanced = new Advanced();
            while (true)
            {
                Console.WriteLine("1 - Ordinary calc\n2 - Advanced calc\nOther to exit");
                var r = Console.ReadLine();
                if (r == "1")
                {
                    try
                    {
                        Console.WriteLine("Choose the action (+,-,*,/)");
                        var a = Console.ReadLine();
                        Console.WriteLine("Enter the first number");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (a == "+") Console.WriteLine($"Answer: {ordinary.Add(num1, num2)}");
                        else if (a == "-") Console.WriteLine($"Answer: {ordinary.Sub(num1, num2)}");
                        else if (a == "*") Console.WriteLine($"Answer: {ordinary.Mul(num1, num2)}");
                        else if (a == "/")
                        {
                            if (num2 == 0) throw new Exception();
                            Console.WriteLine($"Answer: {ordinary.Div(num1, num2)}");
                        }
                        else Console.WriteLine("The action was chosen incorrectly");
                    }
                    catch { Console.WriteLine("Numbers was entred incorrectly"); }
                }
                else if (r == "2")
                {
                    Console.WriteLine("Choose the action (+,-,*,/,ctg)");
                    var a = Console.ReadLine();
                    try
                    {
                        if (a.ToLower() == "ctg")
                        {
                            Console.WriteLine("Enter number: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            if(num1 < -180 || num1 > 180) throw new Exception();
                        }
                        else
                        {
                            Console.WriteLine("Enter the first number: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the second number: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        if (a == "+") Console.WriteLine($"Answer: {advanced.Add(num1, num2)}");
                        else if (a == "-") Console.WriteLine($"Answer: {advanced.Sub(num1, num2)}");
                        else if (a == "*") Console.WriteLine($"Answer: {advanced.Mul(num1, num2)}");
                        else if (a == "/")
                        {
                            if (num2 == 0) throw new Exception();
                            Console.WriteLine($"Answer: {advanced.Div(num1, num2)}");
                        }
                        else if (a.ToLower() == "ctg") Console.WriteLine($"Answer: {advanced.Ctg(num1)}");
                        else Console.WriteLine("The action was chosen incorrectly");
                    }
                    catch { Console.WriteLine("Numbers was entred incorrectly"); }
                }
                else break;
            }
        }
    }
}
