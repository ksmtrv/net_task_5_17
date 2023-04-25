using System;

namespace net_task_5_17
{
    public abstract class GeometricFigure : IFigure
    {
        public string name { get; set; }
        public double length { get; set; }
        public abstract double CountArea();
        public abstract double CountPerimeter();
        
    }
}