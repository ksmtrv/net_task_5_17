﻿using System;

namespace net_task_5_17
{
    public class Rhombus : GeometricFigure
    {
        private bool IsFull { get; set; }
        
        private double height;

        public Rhombus(string name, string colour, double length, double height, bool isFull) : base(name, colour, length)
        {
            if (height < 0)
            {
                throw new ArgumentException("Height must be greater than 0!");
            }
            this.height = height;
            this.IsFull = isFull;
            
        }

        public override double CountArea()
        {
            return height * Length;
        }

        public override double CountPerimeter()
        {
            return 4 * Length;
        }

        public override string ToString()
        {
            return base.ToString() + $"height -> {height}, full -> {IsFull}";
        }
    }
}