using System;

namespace MyPract;

public class Tasks
{
    public static void RunTasks(string[] args)
    {
        List<string> tasks = new List<string>();

        AddTask(tasks, "Buy groceries");
        AddTask(tasks, "Clean the house");
        AddTask(tasks, "Finish the report");
        AddTask(tasks, "Call the bank");
        AddTask(tasks, "Schedule a meeting");
        AddTask(tasks, "Exercise");

        DisplayTasks(tasks);

        Console.WriteLine("Total tasks: " + tasks.Count);
    }

    private static void AddTask(List<string> taskList, string task)
    {
        taskList.Add(task);
    }

    private static void DisplayTasks(List<string> taskList)
    {
        Console.WriteLine("Tasks:");
        foreach (string task in taskList)
        {
            Console.WriteLine("- " + task);
        }
    }
}



// using System;
// using System.Collections.Generic;


// class Tasks
// {
//     public static void RunTasks(string[] args)
//     {
//        List<string> tasks = new List<string>();

//        AddTask(tasks, "Buy groceries");
//        AddTask(tasks, "Clean the house");
//        AddTask(tasks, "Finish the report");
//        AddTask(tasks, "Call the bank");
//        AddTask(tasks, "Schedule a meeting");
//        AddTask(tasks, "Exercise");

//        DisplayTasks(tasks);

//        Console.WriteLine("Total tasks: " + tasks.Count);


//        static void AddTask(List<string> taskList, string task)
//        {
//            taskList.Add(task);
//        }

//        static void DisplayTasks(List<string> taskList)
//        {
//            Console.WriteLine("Tasks:");
//            foreach (string task in taskList)
//            {
//                Console.WriteLine("- " + task);
//            }
//        }
//     }
// }