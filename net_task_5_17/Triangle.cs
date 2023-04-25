﻿using System;

namespace net_task_5_17
{
    public class Triangle : GeometricFigure
    {
        public double side { get; set; }
        
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