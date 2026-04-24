using System;
using System.Collections.Generic;

class Program
{
    static List<string> posts = new List<string>();
    static Dictionary<string, int> likes = new Dictionary<string, int>();
    static HashSet<int> users = new HashSet<int>();
    static Stack<string> actions = new Stack<string>();
    static Queue<string> notifications = new Queue<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Social Media System =====");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Create Post");
            Console.WriteLine("3. Like Post");
            Console.WriteLine("4. Undo Last Action");
            Console.WriteLine("5. Show Posts & Likes");
            Console.WriteLine("6. Process Notifications");
            Console.WriteLine("7. Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    CreatePost();
                    break;
                case 3:
                    LikePost();
                    break;
                case 4:
                    Undo();
                    break;
                case 5:
                    ShowPosts();
                    break;
                case 6:
                    ProcessNotifications();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddUser()
    {
        Console.Write("Enter User ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (users.Add(id))
            Console.WriteLine("User added successfully!");
        else
            Console.WriteLine("User already exists!");
    }

    static void CreatePost()
    {
        Console.Write("Enter post content: ");
        string post = Console.ReadLine();

        posts.Add(post);
        likes[post] = 0;

        Console.WriteLine("Post created!");
    }

    static void LikePost()
    {
        Console.Write("Enter post to like: ");
        string post = Console.ReadLine();

        if (likes.ContainsKey(post))
        {
            likes[post]++;
            actions.Push(post);
            notifications.Enqueue(post + " got a like");

            Console.WriteLine("Post liked!");
        }
        else
        {
            Console.WriteLine("Post not found!");
        }
    }

    static void Undo()
    {
        if (actions.Count > 0)
        {
            string lastPost = actions.Pop();
            likes[lastPost]--;

            Console.WriteLine("Undo successful! Removed like from " + lastPost);
        }
        else
        {
            Console.WriteLine("No actions to undo!");
        }
    }

    static void ShowPosts()
    {
        Console.WriteLine("\nPosts & Likes:");
        foreach (var post in likes)
        {
            Console.WriteLine(post.Key + " -> " + post.Value + " likes");
        }
    }

    static void ProcessNotifications()
    {
        Console.WriteLine("\nNotifications:");
        while (notifications.Count > 0)
        {
            Console.WriteLine(notifications.Dequeue());
        }
    }
}