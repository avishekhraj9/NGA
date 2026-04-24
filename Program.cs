using System;
using System.Collections.Generic;

class TaskScheduler
{
    Queue<string> taskQueue = new Queue<string>();
    Stack<string> undoStack = new Stack<string>();
    List<string> allTasks = new List<string>();
    SortedDictionary<int, string> priorityTasks = new SortedDictionary<int, string>();
    HashSet<string> uniqueTasks = new HashSet<string>();

    // Add Task
    public void AddTask(string task, int priority)
    {
        if (uniqueTasks.Contains(task))
        {
            Console.WriteLine("Task already exists!");
            return;
        }

        uniqueTasks.Add(task);
        allTasks.Add(task);
        taskQueue.Enqueue(task);
        priorityTasks[priority] = task;

        Console.WriteLine($"Added: {task}");
    }

    // Execute Task
    public void ExecuteTask()
    {
        if (taskQueue.Count == 0)
        {
            Console.WriteLine("No tasks to execute.");
            return;
        }

        string task = taskQueue.Dequeue();
        undoStack.Push(task);

        Console.WriteLine($"Executed: {task}");
    }

    // Undo Last Task
    public void UndoTask()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }

        string task = undoStack.Pop();
        taskQueue.Enqueue(task);

        Console.WriteLine($"Undo done: {task} added back");
    }

    // Show Tasks
    public void ShowTasks()
    {
        Console.WriteLine("\nAll Tasks:");
        foreach (var t in allTasks)
            Console.WriteLine(t);
    }

    public void ShowQueue()
    {
        Console.WriteLine("\nTask Queue:");
        foreach (var t in taskQueue)
            Console.WriteLine(t);
    }

    public void ShowPriority()
    {
        Console.WriteLine("\nTasks by Priority:");
        foreach (var t in priorityTasks)
            Console.WriteLine($"Priority {t.Key} -> {t.Value}");
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTask("Backup Database", 2);
        scheduler.AddTask("Clean Temp Files", 3);
        scheduler.AddTask("Update System", 1);

        scheduler.ShowTasks();
        scheduler.ShowQueue();
        scheduler.ShowPriority();

        scheduler.ExecuteTask();
        scheduler.ExecuteTask();

        scheduler.UndoTask();

        scheduler.ShowQueue();

        Console.ReadLine();
    }
}