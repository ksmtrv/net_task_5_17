using System;

namespace net_task_5_17
{
    public abstract class GeometricFigure : IFigure
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Length { get; set; }

        protected GeometricFigure(string name, string colour, double length)
        {
            this.Name = name;
            this.Colour = colour;
            if (length < 0)
            {
                throw new ArgumentException("Length must be greater than 0!");
            }
            this.Length = length;
        }

        public abstract double CountArea();
        public abstract double CountPerimeter();

        public override string ToString()
        {
            return $"Name -> {Name}, colour -> {Colour}, length -> {Length},\n" +
                   $"area -> {CountArea()}, perimeter -> {CountPerimeter()},\n";
        }
    }
}