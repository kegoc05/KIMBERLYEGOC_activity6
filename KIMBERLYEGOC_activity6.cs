using System;

class Program
{
    static void Main()
    {
        string currentMenu = "main";
        bool running = true;

        while (running)
        {
            Console.Clear();

            switch (currentMenu)
            {
                case "main":
                    Console.WriteLine("=== MAIN MENU ===");
                    Console.WriteLine("A. File");
                    Console.WriteLine("B. Edit");
                    Console.WriteLine("C. View");
                    Console.WriteLine("X. Exit");
                    break;

                case "file":
                    Console.WriteLine("=== FILE MENU ===");
                    Console.WriteLine("A. New");
                    Console.WriteLine("B. Open");
                    Console.WriteLine("C. Save");
                    Console.WriteLine("B. Back");
                    break;

                case "edit":
                    Console.WriteLine("=== EDIT MENU ===");
                    Console.WriteLine("A. Cut");
                    Console.WriteLine("B. Copy");
                    Console.WriteLine("C. Paste");
                    Console.WriteLine("B. Back");
                    break;

                case "view":
                    Console.WriteLine("=== VIEW MENU ===");
                    Console.WriteLine("A. Zoom In");
                    Console.WriteLine("B. Zoom Out");
                    Console.WriteLine("C. Fullscreen");
                    Console.WriteLine("B. Back");
                    break;
            }

            Console.Write("\nEnter your choice: ");
            string input = Console.ReadLine().ToLower();

            if (input == "x")
            {
                running = false;
            }
            else if (currentMenu == "main")
            {
                if (input == "a") currentMenu = "file";
                else if (input == "b") currentMenu = "edit";
                else if (input == "c") currentMenu = "view";
            }
            else
            {
                // Back from submenu to main
                if (input == "b") currentMenu = "main";
                else
                {
                    Console.WriteLine("\nYou selected a submenu item. Press any key to go back...");
                    Console.ReadKey();
                }
            }
        }

        Console.WriteLine("\nProgram ended.");
    }
}
