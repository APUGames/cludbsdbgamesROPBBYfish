using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine("Whale, come");
    Console.WriteLine("best fish?");

    string[] guests = new string[]{"tilapia", "whitefish", "trout", "what are fish all about?"};
    string[] clubMembers = new string[10];

    int guestIndex = 0;

    foreach(var guest in guests)
    {
        Console.WriteLine($"Is {guest} a fish? (yes/no)");
        string input = Console.ReadLine().ToLower();

        if(input == "yes")
        {
            clubMembers[guestIndex] = guest;
            guestIndex++;
            Console.WriteLine($"{guest} is a fish.");
        }
        else
        {
            Console.WriteLine($"{guest} is not longer and fish");
        }
    }

    Console.WriteLine("\nThese are the most pretty fish I've seen");
    foreach (var member in clubMembers)
    {
        Console.WriteLine(member);
    }

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
  
}
