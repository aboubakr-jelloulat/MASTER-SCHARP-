using System;

namespace Portfolio
{
    /// <summary>
    /// Represents Aboubakr Jelloulat and his professional profile.
    /// </summary>
    public class WhoAmi
    {
        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Title { get; private set; }
        public string Organization { get; private set; }
        public string Email { get; private set; }
        public string Description { get; private set; }

        // Constructor
        public WhoAmi()
        {
            FirstName = "Aboubakr";
            LastName = "Jelloulat";
            Title = "Software Engineer";
            Organization = "42 The Network";
            Email = "aboubakerjelloulat@gmail.com";
            Description = "Repository for mastering C# and building impressive projects.";
        }

        // Methods
        public void DisplayProfile()
        {
            Console.WriteLine("=== Who Am I ===");
            Console.WriteLine($"Name        : {FirstName} {LastName}");
            Console.WriteLine($"Title       : {Title}");
            Console.WriteLine($"Organization: {Organization}");
            Console.WriteLine($"Email       : {Email}");
            Console.WriteLine($"Description : {Description}");
        }
    }

    // Test the class
    class Program
    {
        static void Main(string[] args)
        {
            WhoAmi me = new WhoAmi();
            me.DisplayProfile();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
