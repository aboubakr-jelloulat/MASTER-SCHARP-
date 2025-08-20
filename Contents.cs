using System;

namespace Portfolio
{
    /// <summary>
    /// Represents the content topics of this C# repository.
    /// </summary>
    public class Contents
    {
        // Array of topics
        private string[] topics = new string[]
        {
            "C# Fundamentals",
            "C# Advanced",
            "C# Data Structures",
            "C# Object-Oriented Programming (OOP)"
        };

        // Method to display the topics
        public void DisplayContents()
        {
            Console.WriteLine("=== C# Repository Contents ===\n");
            for (int i = 0; i < topics.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {topics[i]}");
            }
            Console.WriteLine("\nThis repository is designed to master C# and build professional projects.");
        }
    }

    // Test the class
    class Program
    {
        static void Main(string[] args)
        {
            Contents repoContents = new Contents();
            repoContents.DisplayContents();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
