using ConsoleApp53.Methods;

namespace ConsoleApp53.Interfaces;

public interface ITaskService
{
    public void AddTask(MyTask task);
    public MyTask GetTaskByTitle(string title);
    public List<MyTask> GetAllTasksByStatus(TaskStatus status);
    public void DeleteById(int id);
}
