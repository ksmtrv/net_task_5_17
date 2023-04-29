using System;
using System.Collections.Generic;

namespace net_task_5_17
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            List<IFigure> figures = new List<IFigure>();
            figures.Add(new Rhombus("Rhombus","Red", 14,10, true));
            figures.Add(new Circle("Circle", "Blue", 10, true));
            figures.Add(new Triangle("Triangle","Green",13, 12,30,true));
            
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine("-----");
            }
        }

    }
}