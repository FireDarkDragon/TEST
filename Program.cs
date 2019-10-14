 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Дармограй Артем ИУ5-32Б";
            bool correct = false;
            double a=0, b=0, c=0;
            while (correct == false)
            {
                Console.WriteLine("Введите коэффициент a");
                 string str1 = Console.ReadLine();
                Console.WriteLine("Введите коэффициент b");
                 string str2 = Console.ReadLine();
                Console.WriteLine("Введите коэффициент c");
                 string str3 = Console.ReadLine();
                if (double.TryParse(str1,out a) && double.TryParse(str2, out b) && double.TryParse(str3, out c))
                {
                    a = double.Parse(str1);
                    b = double.Parse(str2);
                    c = double.Parse(str3);
                    if(a==0 && b == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Коэффициенты a и b не могут равняться 0 одновременно");
                        Console.WriteLine("Пожалуйста, повторите ввод данных.");
                        Console.ResetColor();
                    }
                    else
                    {
                        correct = true;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициенты введены некорректно.");
                    Console.WriteLine("Пожалуйста, повторите ввод данных.");
                    Console.ResetColor();

                }

            }
            double D = b * b - 4 * a * c;
            if(D < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет.");
                Console.ResetColor();
            }
            else
            {
                if (a == 0)
                {
                    c = -c / b;
                    if (c < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет.");
                        Console.ResetColor();
                    }
                    else if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        double x = Math.Sqrt(c);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}", -x);
                        Console.WriteLine("x2 = {0}", x);
                        Console.ResetColor();
                    }
                }
                else if( b == 0)
                {
                    c = -c / a;
                    if (c < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет.");
                        Console.ResetColor();
                    }
                    else if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        double x = Math.Pow(c,0.25);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}", -x);
                        Console.WriteLine("x2 = {0}", x);
                        Console.ResetColor();
                    }
                }
                else if( c == 0)
                {
                    double x_  = -b / a;
                    if (x_ < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        x_ = Math.Sqrt(x_);
                        Console.WriteLine("x1 = {0}", -x_);
                        Console.WriteLine("x2 = 0");
                        Console.WriteLine("x3 = {0}", x_);
                        Console.ResetColor();
                    }

                }
                else if(D == 0)
                {
                    double x = -b / (2*a);
                    if (x < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет.");
                        Console.ResetColor();
                    }
                    else
                    {
                        x = Math.Sqrt(x);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}",-x);
                        Console.WriteLine("x2 = {0}", x);
                        Console.ResetColor();
                    }
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                    if(x1 < 0 && x2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет.");
                        Console.ResetColor();
                    }
                    else if (x1 < 0)
                    {
                        x2 = Math.Sqrt(x2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}", -x2);
                        Console.WriteLine("x2 = {0}", x2);
                        Console.ResetColor();
                    }
                    else if (x2 < 0)
                    {
                        x1 = Math.Sqrt(x1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}", -x1);
                        Console.WriteLine("x2 = {0}", x1);
                        Console.ResetColor();
                    }
                    else
                    {
                        x1 = Math.Sqrt(x1);
                        x2 = Math.Sqrt(x2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("x1 = {0}", -x1);
                        Console.WriteLine("x2 = {0}", x1);
                        Console.WriteLine("x3 = {0}", -x2);
                        Console.WriteLine("x4 = {0}", x2);
                        Console.ResetColor();
                    }
                }
            }
            System.Environment.Exit(0);
        }
    }
}
