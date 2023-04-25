namespace net_task_5_17
{
    public interface IFigure
    {
        string name { get; set; }
        string colour { get; set; }
        double CountArea();
        double CountPerimeter();
        string ToString();
    }
}