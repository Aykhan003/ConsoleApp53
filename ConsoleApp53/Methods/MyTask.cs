namespace ConsoleApp53.Methods;

public class MyTask
{
    private static int _idCounter = 0;
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Explanation { get; set; } = null!;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime DeadLine { get; set; }
    public TaskStatus Status { get; set; }
    public MyTask(string title, string explanation, DateTime deadLine, TaskStatus status)
    {
        Id = ++_idCounter;
        Title = title;
        Explanation = explanation;
        DeadLine = deadLine;
        Status = status;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Explanation: {Explanation}, Created: {Created}, DeadLine: {DeadLine}, Status: {Status}";
    }

}
