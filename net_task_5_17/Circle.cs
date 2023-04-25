using System;

namespace net_task_5_17
{
    public class Circle : GeometricFigure
    {
        public double CountSectorArea(double angle = 10)
        {
            return Math.PI * length * length * angle / 360;
        }

        public override double CountArea() 
        {
            return Math.PI * length * length;
        }
        
        public override double CountPerimeter()
        {
            return 2 * Math.PI * length;
        }
    }
}