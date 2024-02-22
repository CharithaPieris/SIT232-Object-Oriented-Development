using System;
using System.Collections.Generic;

namespace TaskPlanner
{
    class Task
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public ConsoleColor Color { get; set; }
    }

    class Category
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; } = new List<Task>();

        public void AddTask(string description, DateTime dueDate, ConsoleColor color)
        {
            Tasks.Add(new Task { Description = description, DueDate = dueDate, Color = color });
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < Tasks.Count)
            {
                Tasks.RemoveAt(index);
            }
        }
    }

    class TaskPlanner
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { Name = "Personal" },
                new Category { Name = "Work" },
                new Category { Name = "Family" }
            };

            while (true)
            {
                Console.Clear();
                DisplayCategories(categories);
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Delete a task");
                Console.WriteLine("3. Add a new category");
                Console.WriteLine("4. Delete a category");
                Console.WriteLine("5. Move a task to another category");
                Console.WriteLine("6. Highlight important tasks");
                Console.WriteLine("0. Exit");


                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddTask(categories);
                            break;
                        case 2:
                            DeleteTask(categories);
                            break;
                        case 3:
                            AddCategory(categories);
                            break;
                        case 4:
                            DeleteCategory(categories);
                            break;
                        case 5:
                            MoveTask(categories);
                            break;
                        case 6:
                            HighlightTasks(categories);
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        static void DisplayCategories(List<Category> categories)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CATEGORIES");
            Console.WriteLine(new string('-', 94));
            Console.WriteLine("{0,-10}|{1,-30}|{2,-30}|{3,-30}|", "item #", "Personal", "Work", "Family");
            Console.WriteLine(new string('-', 94));

            int maxTasksCount = categories.Max(c => c.Tasks.Count);

            for (int i = 0; i < maxTasksCount; i++)
            {
                Console.Write("{0,-10}|", i);

                foreach (var category in categories)
                {
                    if (category.Tasks.Count > i)
                    {
                        Console.ForegroundColor = category.Tasks[i].Color;
                        Console.Write("{0,-30}|", $"{category.Tasks[i].DueDate:MM/dd/yyyy} - {category.Tasks[i].Description}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0,-30}|", "N/A");
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        static void AddTask(List<Category> categories)
        {
            Console.Write("Enter the category name (Personal/Work/Family): ");
            string categoryName = Console.ReadLine();
            Category category = categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (category != null)
            {
                Console.Write("Enter task description (max. 30 symbols): ");
                string description = Console.ReadLine();

                Console.Write("Enter due date (MM/dd/yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dueDate))
                {
                    Console.Write("Highlight task? (y/n): ");
                    bool highlight = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);

                    category.AddTask(description, dueDate, highlight ? ConsoleColor.Red : ConsoleColor.White);
                    Console.WriteLine("Task added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid date format. Task not added.");
                }
            }
            else
            {
                Console.WriteLine("Category not found. Task not added.");
            }
        }

        static void DeleteTask(List<Category> categories)
        {
            Console.Write("Enter the category name (Personal/Work/Family): ");
            string categoryName = Console.ReadLine();
            Category category = categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (category != null)
            {
                DisplayTasks(category);
                Console.Write("Enter the task number to delete: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    category.RemoveTask(taskNumber);
                    Console.WriteLine("Task deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid task number. Task not deleted.");
                }
            }
            else
            {
                Console.WriteLine("Category not found. Task not deleted.");
            }
        }

        static void DisplayTasks(Category category)
        {
            Console.WriteLine($"Tasks in {category.Name} category:");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < category.Tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {category.Tasks[i].DueDate:MM/dd/yyyy} - {category.Tasks[i].Description}");
            }
            Console.WriteLine(new string('-', 50));
        }

        static void AddCategory(List<Category> categories)
        {
            Console.Write("Enter a new category name: ");
            string newCategoryName = Console.ReadLine();

            if (categories.Find(c => c.Name.Equals(newCategoryName, StringComparison.OrdinalIgnoreCase)) == null)
            {
                categories.Add(new Category { Name = newCategoryName });
                Console.WriteLine("Category added successfully.");
            }
            else
            {
                Console.WriteLine("Category with the same name already exists. Category not added.");
            }
        }

        static void DeleteCategory(List<Category> categories)
        {
            Console.Write("Enter the category name to delete: ");
            string categoryName = Console.ReadLine();
            Category categoryToDelete = categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (categoryToDelete != null)
            {
                categories.Remove(categoryToDelete);
                Console.WriteLine("Category and its tasks deleted successfully.");
            }
            else
            {
                Console.WriteLine("Category not found. Category not deleted.");
            }
        }

        static void MoveTask(List<Category> categories)
        {
            Console.Write("Enter the task category name (Personal/Work/Family): ");
            string categoryName = Console.ReadLine();
            Category sourceCategory = categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (sourceCategory != null)
            {
                DisplayTasks(sourceCategory);
                Console.Write("Enter the task number to move: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    if (taskNumber >= 0 && taskNumber < sourceCategory.Tasks.Count)
                    {
                        Console.Write("Enter the target category name (Personal/Work/Family): ");
                        string targetCategoryName = Console.ReadLine();
                        Category targetCategory = categories.Find(c => c.Name.Equals(targetCategoryName, StringComparison.OrdinalIgnoreCase));

                        if (targetCategory != null)
                        {
                            Task taskToMove = sourceCategory.Tasks[taskNumber];
                            targetCategory.Tasks.Add(taskToMove);
                            sourceCategory.Tasks.RemoveAt(taskNumber);
                            Console.WriteLine("Task moved successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Target category not found. Task not moved.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number. Task not moved.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid task number. Task not moved.");
                }
            }
            else
            {
                Console.WriteLine("Category not found. Task not moved.");
            }
        }

        static void HighlightTasks(List<Category> categories)
        {
            Console.Write("Enter the task category name (Personal/Work/Family): ");
            string categoryName = Console.ReadLine();
            Category category = categories.Find(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            if (category != null)
            {
                DisplayTasks(category);
                Console.Write("Enter the task number to highlight: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    if (taskNumber >= 0 && taskNumber < category.Tasks.Count)
                    {
                        Task taskToHighlight = category.Tasks[taskNumber];
                        taskToHighlight.Color = ConsoleColor.Red;
                        Console.WriteLine("Task highlighted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number. Task not highlighted.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid task number. Task not highlighted.");
                }
            }
            else
            {
                Console.WriteLine("Category not found. Task not highlighted.");
            }
        }
    }
}
