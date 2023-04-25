namespace net_task_5_17
{
    public interface IFigure
    {
        string name { get; set; }
        double CountArea();
        double CountPerimeter();
    }
}