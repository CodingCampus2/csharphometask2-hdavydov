using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                const int padding = Task2.Padding;
                float balance = task.Balance;
                char symbol = task.DecorativeSign;

                string str = $"{"",-1 * padding/2}${balance:N2}{"",padding/2}";

                int length = str.Length;

                return str.PadLeft(length + padding / 2, symbol).PadRight(length + padding, symbol);
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
