using System;

class Program
{
    static void Main()
    {
        string menu = "home";
        
        while (true)
        {
            Console.Clear();
            
            if (menu == "home")
            {
                Console.WriteLine("1. Database Models");
                Console.WriteLine("2. Web Frontend");
                Console.WriteLine("0. Exit");
                
                string choice = Console.ReadLine();
                if (choice == "1") menu = "database";
                else if (choice == "2") menu = "web";
                else if (choice == "0") break;
            }
            else if (menu == "database")
            {
                Console.WriteLine("1. Relational");
                Console.WriteLine("2. Non-Relational");
                Console.WriteLine("0. Back");
                
                string choice = Console.ReadLine();
                if (choice == "1") menu = "relational";
                else if (choice == "2") menu = "nonrel";
                else if (choice == "0") menu = "home";
            }
            else if (menu == "relational")
            {
                Console.WriteLine("1. SQL");
                Console.WriteLine("2. ACID");
                Console.WriteLine("0. Back");
                
                string choice = Console.ReadLine();
                if (choice == "0") menu = "database";
                else Console.ReadKey();
            }
            else if (menu == "nonrel")
            {
                Console.WriteLine("1. NoSQL");
                Console.WriteLine("2. CAP");
                Console.WriteLine("0. Back");
                
                string choice = Console.ReadLine();
                if (choice == "0") menu = "database";
                else Console.ReadKey();
            }
            else if (menu == "web")
            {
                Console.WriteLine("1. Markup");
                Console.WriteLine("2. Styling");
                Console.WriteLine("0. Back");
                
                string choice = Console.ReadLine();
                if (choice == "1") menu = "markup";
                else if (choice == "2") menu = "styling";
                else if (choice == "0") menu = "home";
            }
            else if (menu == "markup")
            {
                Console.WriteLine("1. HTML");
                Console.WriteLine("2. XML");
                Console.WriteLine("0. Back");
                
                string choice = Console.ReadLine();
                if (choice == "0") menu = "web";
                else Console.ReadKey();
            }
            else if (menu == "styling")
            {
                Console.WriteLine("1. CSS");
                Console.WriteLine("2. Sass");
                Console.WriteLine("0. Back");
                
                string choice = Console.ReadLine();
                if (choice == "0") menu = "web";
                else Console.ReadKey();
            }
        }
    }
}
