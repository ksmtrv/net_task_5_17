using System.Collections.Generic;

namespace net_task_5_17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();
            figures.Add(new Rhombus(10, true));
            figures.Add(new Rhombus(5.4, false));
        }
    }
}