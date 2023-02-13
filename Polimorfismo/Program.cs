using Polimorfismo.Entities;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;


namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employee: ");
            int numberEmployee = int.Parse(Console.ReadLine());


            List<Employee> list = new List<Employee>();
            for (int i = 0; i < numberEmployee; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.WriteLine("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valueHour));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueHour));
                }

            }
        }
    }
}