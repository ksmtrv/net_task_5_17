using System;

namespace net_task_5_17
{
    public class Triangle : GeometricFigure
    {
        public bool isFull { get; set; }
        public double side { get; set; }

        public Triangle(bool isFull, double side)
        {
            if (side < 0)
            {
                throw new ArgumentException("Side must be greater than 0!");
            }
            this.side = side;            
            this.isFull = isFull;
        }

        public double CountThirdSide()
        {
            return Math.Sqrt(length*length + side*side - 2*length*side*Math.Cos(angle*Math.PI*180));
        }

        public override double CountArea()
        {
            return length * side * Math.Sin(angle * Math.PI * 180);
        }
        
        public override double CountPerimeter()
        {
            double thirdSide = CountThirdSide();
            return length * this.side * thirdSide;
        }
    }
}