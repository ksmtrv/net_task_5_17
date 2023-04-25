using System;

namespace net_task_5_17
{
    public class Rhombus : GeometricFigure
    {
        private bool isFull { get; set; }
        
        private double height;

        public Rhombus(string name, string colour, double length, double height, bool isFull) : base(name, colour, length)
        {
            if (height < 0)
            {
                throw new ArgumentException("Height must be greater than 0!");
            }
            this.height = height;
            this.isFull = isFull;
            
        }

        public override double CountArea()
        {
            return height * length;
        }

        public override double CountPerimeter()
        {
            return 4 * length;
        }

        public override string ToString()
        {
            return base.ToString() + $"height -> {height}, full -> {isFull}";
        }
    }
}