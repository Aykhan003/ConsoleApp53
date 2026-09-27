using ConsoleApp53.Interfaces;

namespace ConsoleApp53.Methods;

internal class TaskService : ITaskService
{
    private static List<MyTask> _tasks = new List<MyTask>();
    public void AddTask(MyTask task)
    {
        foreach (var t in _tasks)
        {
            if (t.Title == task.Title)
            {
                throw new Exception("Task with this title already exists.");
            }
        }
        _tasks.Add(task);
    }
    public MyTask GetTaskByTitle(string title)
    {
        foreach (var task in _tasks)
        {
            if (task.Title == title)
            {
                return task;
            }
        }
        throw new Exception("Task not found.");
    }
    public List<MyTask> GetAllTasksByStatus(TaskStatus status)
    {
        var tasks = new List<MyTask>();
        foreach (var task in _tasks)
        {
            if (task.Status == status)
            {
                tasks.Add(task);
            }
        }
        return tasks;
    }
    public void DeleteById(int id)
    {
        _tasks.RemoveAll(t => t.Id == id);
    }
}
