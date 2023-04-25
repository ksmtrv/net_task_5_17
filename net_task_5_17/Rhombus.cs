using System;

namespace net_task_5_17
{
    public class Rhombus : GeometricFigure
    {
        public bool isFull { get; set; }
        
        private double height;

        public Rhombus(double height, bool isFull)
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
        
        public double CountAreaWithAngle(double angle = 45)
        {
            return length * length * Math.Sin(angle);
        }

        public double CountAreaWithHeight(double height = 10)
        {
            return height * length;
        }
        
    }
}