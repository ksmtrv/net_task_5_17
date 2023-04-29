using System;

namespace net_task_5_17
{
    public class Triangle : GeometricFigure
    {
        private bool IsFull { get; set; }
        private double Side { get; set; }
        private double Angle { get; set; }

        public Triangle(string name, string colour, double length, double side, double angle, bool isFull) : base(name, colour, length)
        {
            if (side < 0)
            {
                throw new ArgumentException("Side must be greater than 0!");
            }
            this.Side = side;

            if (angle < 0)
            {
                throw new ArgumentException("Angle must be greater than 0!");
            }
            this.Angle = angle;
            
            this.IsFull = isFull;
        }

        public double CountThirdSide()
        {
            return Math.Sqrt(Length * Length + Side * Side - 2 * Length * Side * Math.Cos(Angle * Math.PI*180));
        }

        public override double CountArea()
        {
            return Length * Side * Math.Sin(Angle * Math.PI * 180);
        }
        
        public override double CountPerimeter()
        {
            double thirdSide = CountThirdSide();
            return Length * Side * thirdSide;
        }
        
        public override string ToString()
        {            
            return base.ToString() + $"side -> {Side}, angle -> {Angle}, full -> {IsFull}";
        }
    }
}