using System;

namespace net_task_5_17
{
    public class Circle : GeometricFigure
    {
        private bool IsFull { get; set; }

        public Circle(string name, string colour, double length, bool isFull): base(name, colour, length)
        {
            this.IsFull = isFull;
        }

        public override double CountArea() 
        {
            return Math.PI * length * length;
        }
        
        public override double CountPerimeter()
        {
            return 2 * Math.PI * length;
        }
        
        public override string ToString()
        {
            return base.ToString() + $"full -> {IsFull}";
        }
    }
}