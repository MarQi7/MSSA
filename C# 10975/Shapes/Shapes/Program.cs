using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
        choice:
            Console.WriteLine("Hello! Please select an option: \n[1]Circle \n[2] Square");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Calculating the area of a Circle *");
                Circle pie = new Circle();
                Console.WriteLine($"ID: {pie.Id}\nName: {pie.Name}\nColor: {pie.Color}\nArea: {pie.CalculateArea()}");
                Console.ReadKey();
            }
            else if (choice == 2)
            {
                Console.Write("\n\nCalculating the area of a Square *");
                Square box = new Square();
                Console.WriteLine($"ID: {box.Id}\nName: {box.Name}\nColor: {box.Color}\nArea: {box.CalculateArea()}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry, that's not an option");
                Console.ReadKey();
                goto choice;
            }
    }
}
