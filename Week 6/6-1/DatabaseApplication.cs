using System;
using System.Collections.Generic;

namespace _6_1
{
    class DatabaseApplication
    {
        public List<string> Database { set;  get; } = new List<string>();
        public List<string> Commands { get; } = new List<string>
    {
        "add",
        "help",
        "list",
        "quit",
        "delete"
    };

        public void Run()
        {
            Load();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** Welcome to Initech Data Systems 1.0 ***");
            Console.WriteLine();
            Console.ResetColor();

            string command;

            do
            {
                command = GetCommand();

                if (command == "add")
                {
                    Console.Write("Please input company name to add: ");
                    Add(Console.ReadLine());
                }
                else if (command == "help")
                {
                    Console.WriteLine("-- Available commands --");
                    foreach (var option in Commands)
                    {
                        if (option == "help")
                        {
                            continue;
                        }

                        Console.WriteLine(option);
                        
                    }

                    Console.WriteLine();
                }
                else if (command == "delete")
                {
                    Console.Write("Please input company name to delete: ");
                    Delete(Console.ReadLine());
                }
                else if (command == "list")
                {
                    List();
                }

            } while (command != "quit");
        }

        public string GetCommand()
        {
            while (true)
            {
                Console.Write("Please input a command, or \"help\": ");

                var input = Console.ReadLine()!;

                if (Commands.Contains(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK");
                    Console.WriteLine();
                    Console.ResetColor();

                    return input;
                }

                Console.WriteLine("?");
                Console.WriteLine();
            }
        }

        public void Add(string inputCompany)
        {
            if (!string.IsNullOrEmpty(inputCompany))
            {
                Database.Add(inputCompany);
                Console.WriteLine($"{inputCompany} added to database!");
                Save();
                Console.WriteLine();
            }
        }

        public void List()
        {
            foreach (var listItem in Database)
            {
                Console.WriteLine(listItem);
            }

            Console.WriteLine();
        }
        public void Delete(string removeCompany)
        {
            if (!string.IsNullOrEmpty(removeCompany))
            {
                if (Database.Contains(removeCompany))
                {
                    Database.Remove(removeCompany);
                    Console.WriteLine($"{removeCompany} removed from database!");
                    Save();
                }
                else
                {
                    Console.WriteLine($"{removeCompany} is not found in database");
                }

                Console.WriteLine();
            }
        }
        public void Load()
        {
            var filename = "/Users/vargvinter/Projects/Week 6/6-1/database.txt";

            // if the file exists, read it and create a list from it
            if (File.Exists(filename))
            {
                Database = File.ReadAllLines(filename).ToList();
            }
        }

        public void Save()
        {
            var filename = "/Users/vargvinter/Projects/Week 6/6-1/database.txt";
            var list = Database;

            File.WriteAllLines(filename, list);
        }
    }
}

