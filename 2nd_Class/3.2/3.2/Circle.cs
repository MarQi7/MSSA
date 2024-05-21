using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Circle
    {
        public double Radius { get; set; }
        private double area;
        public double Area
        {
            get { return area; }
        }

        private void GetRadius()
        {
            this.Radius = Math.Sqrt((this.area/Math.PI));
        }
        public double CalculateArea()
        {
            this.area = Math.PI * this.Radius * this.Radius;
            return this.area;
        }
        public static Circle operator +(Circle c1, Circle c2) //creates a method for adding these objects with "+"
        {
            Circle cnew = new Circle();
            cnew.area = c1.Area + c2.Area; // combines the two radius before calculating the area...
            cnew.GetRadius();
            return cnew;
        }
        public static Circle operator -(Circle c1, Circle c2)
        {
            Circle cnew = new Circle();
            cnew.area = c1.Area - c2.Area; // combines the two radius before calculating the area...
            cnew.GetRadius();
            return cnew;
        }
        // if by radius:
        // cnew.Radius = c1.Radius + c2.Radius;
        // cnew.CalculateArea();
    }
}
