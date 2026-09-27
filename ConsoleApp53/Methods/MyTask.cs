namespace ConsoleApp53.Methods;

internal class MyTask
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Explanation { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime DeadLine { get; set; }
    public TaskStatus Status { get; set; }

}
