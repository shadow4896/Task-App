using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectnum = 0;
            Console.WriteLine("Welcome to the Console Task Manager List");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("What would you like to do:");
            List<string> TaskList = new List<string>();

            Console.WriteLine("1. Create an item. \n2. Action an item\n0. Exit out program");
            selectnum = int.Parse(Console.ReadLine());

            if (selectnum == 1)
            {
                Console.WriteLine("Add a task");
                string task = "";
                Console.WriteLine("Please enter a task");
                task = Console.ReadLine();
                TaskList.Add(task);
                
            }
            else if (selectnum == 2)
            {
                Console.WriteLine("You would like to action an item");
            }
            else if (selectnum == 0)
                Console.WriteLine("Thank you, Good bye!!!);");


            Console.WriteLine(TaskList[0]);

        }
        public static string Task()
        {
            string taskList = "";
            Console.WriteLine("Please enter a task");
            taskList = Console.ReadLine();
            return taskList;
        }


    }
}
