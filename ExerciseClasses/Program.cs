using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1,side2);
            Console.WriteLine($"Area of Rectangle = {rectangle.Area}");
            Console.WriteLine($"Perimeter of Rectangle = {rectangle.Perimeter}");

            Console.WriteLine("-----------------------------------------------");
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            string content = Console.ReadLine();
            Book book = new Book();
            book.Show(title, author, content);

            Console.WriteLine("-----------------------------------------------");
            Converter converter = new Converter(440, 6, 550);
            Console.WriteLine(converter.ConvertToAMD(5000, "Usd")); 
            Console.WriteLine(converter.ConvertToAMD(5000, "Eur"));
            Console.WriteLine(converter.ConvertToAMD(5000, "Rub"));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(converter.ConvertToValyut(5000, "Usd"));
            Console.WriteLine(converter.ConvertToValyut(5000, "Eur"));
            Console.WriteLine(converter.ConvertToValyut(5000, "Rub"));
            Console.WriteLine("-----------------------------------------------");
            Employee employee = new Employee("khachatur", "Manukyan");
            employee.PayrollAndTaxCalculator("Banvor", 1);
            Console.ReadLine();
        }
    }
}
