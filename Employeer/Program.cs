using OOP.Entities;
using System.Globalization;
using System.Transactions;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Employyer #{i} data: ");

                Console.Write("Outsourced (y/n) ?");
                char yn = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (yn == 'Y' || yn == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double addcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name, horas, valorhora, yn));
                }
                else
                {
                    list.Add(new Employee(name, horas, valorhora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}