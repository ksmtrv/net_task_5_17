﻿namespace net_task_5_17
{
    public interface IFigure
    {
        string Name { get; set; }
        double CountArea();
        double CountPerimeter();
    }
}