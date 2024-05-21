using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;

namespace Shapes
{
    abstract class Shape
    {
        protected string id;
        public string Id { get { return id; } }
        protected string name;
        public string Name { get { return name; } }
        protected string color;
        public string Color { get { return color; } }


        public abstract float CalculateArea();
        Random rnd = new Random();
        public void AssignID()
        {
            this.id = "0cx000" + rnd.Next(1, 20);
        }


    }

    class Circle : Shape
    {
        private int radius;
        public Circle()
        {
            AssignID();
            Console.Write("\nPlease enter a name for your circle: ");
            this.name = Console.ReadLine();
        choice:
            Console.WriteLine("\nPlease choose a color for your circle: \n[1] Red \n[2] Blue \n[3] Green ");
            int color = int.Parse(Console.ReadLine());
            switch (color)
            {
                case 1:
                    this.color = "Red";
                    break;
                case 2:
                    this.color = "Blue";
                    break;
                case 3:
                    this.color = "Green";
                    break;
                default:
                    Console.WriteLine("Invalid selection...");
                    goto choice;

            }
            Console.Write("\nPlease enter the radius for your circle: ");
            radius = int.Parse(Console.ReadLine());

        }
        public override float CalculateArea()
        {
            return ((float)radius * (float)radius) * 3.141592f;
        }
    }
    class Square : Shape
    {
        private int side;
        public Square()
        {
            AssignID();
            Console.Write("\nPlease enter a name for your square: ");
            this.name = Console.ReadLine();
        choice:
            Console.WriteLine("\nPlease choose a color for your square: \n[1] Red \n[2] Blue \n[3] Green ");
            int color = int.Parse(Console.ReadLine());
            switch (color)
            {
                case 1:
                    this.color = "Red";
                    break;
                case 2:
                    this.color = "Blue";
                    break;
                case 3:
                    this.color = "Green";
                    break;
                default:
                    Console.WriteLine("Invalid selection...");
                    goto choice;

            }
            Console.Write("\nPlease enter the length of the side of your square: ");
            side = int.Parse(Console.ReadLine());
        }
        public override float CalculateArea()
        {
            return (side * side);
        }
    }






}
