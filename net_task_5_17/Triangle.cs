using System;

namespace net_task_5_17
{
    public class Triangle : GeometricFigure
    {
        public bool isFull { get; set; }
        public double side { get; set; }
        public double angle { get; set; }

        public Triangle(double side, double angle, bool isFull)
        {
            if (side < 0)
            {
                throw new ArgumentException("Side must be greater than 0!");
            }
            this.side = side;

            if (angle < 0)
            {
                throw new ArgumentException("Angle must be greater than 0!");
            }
            this.angle = angle;
            
            this.isFull = isFull;
        }

        public double CountThirdSide()
        {
            return Math.Sqrt(length * length + side * side - 2 * length * side * Math.Cos(angle * Math.PI*180));
        }

        public override double CountArea()
        {
            return length * side * Math.Sin(angle * Math.PI * 180);
        }
        
        public override double CountPerimeter()
        {
            double thirdSide = CountThirdSide();
            return length * side * thirdSide;
        }
    }
}