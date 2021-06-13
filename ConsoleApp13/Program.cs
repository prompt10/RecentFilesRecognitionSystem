using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1, menu_number;
            List<string> files_name = new List<string>();
            files_name.Add("");
            files_name.Add("");
            files_name.Add("");
            files_name.Add("");
            files_name.Add("");
            files_name.Add("");
            while (loop == 1)
            {
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                Console.WriteLine("[0] Show all recent files");
                Console.WriteLine("[1] Open new file");
                Console.WriteLine("[2] Open recent file");
                Console.WriteLine("[3] Exit");
                menu_number = int.Parse(Console.ReadLine());
                if (menu_number == 0)
                {
                    files_name.Reverse();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("[{0}]", i+1);
                        string s = files_name[i];
                        Console.WriteLine(s);
                    }
                    files_name.Reverse();
                }

                if (menu_number == 1)
                {
                    string new_files = Console.ReadLine();
                    files_name.Add(new_files);
                }

                if (menu_number == 2)
                {
                    files_name.Reverse();
                    int select = int.Parse(Console.ReadLine());
                    if (files_name[select] == "" || select > 4)
                    {
                        files_name.Reverse();
                        Console.WriteLine("No recent file.");
                    }
                    else
                    {
                        select = files_name.Count- (select+6);
                        files_name.Reverse();
                        files_name.Add(files_name[select]);
                    }
                }

                if (menu_number == 3)
                {
                    break;
                }

                if (menu_number != 0 && menu_number != 1 && menu_number != 2 && menu_number != 3)
                {
                    Console.WriteLine("Invalid menu number.");
                }
            }



        }
    }
}
