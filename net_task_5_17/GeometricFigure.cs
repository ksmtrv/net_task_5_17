using System;

namespace net_task_5_17
{
    public abstract class GeometricFigure : IFigure
    {
        public string name { get; set; }
        public string colour { get; set; }
        public double length { get; set; }

        protected GeometricFigure(string name, string colour, double length)
        {
            this.name = name;
            this.colour = colour;
            if (length < 0)
            {
                throw new ArgumentException("Length must be greater than 0!");
            }
            this.length = length;
        }

        public abstract double CountArea();
        public abstract double CountPerimeter();

        public virtual string ToString()
        {
            return $"Name -> {name}, colour -> {colour}, length -> {length},\n" +
                   $"area -> {CountArea()}, perimeter -> {CountPerimeter()},\n";
        }
    }
}