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

                FormattableString balanceFormat = $"{balance:C2}";

                string balanceStr = balanceFormat.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                string answerStr = $"{"",-1 * padding/2}{balanceStr}{"",padding/2}";

                int length = answerStr.Length;



                return answerStr.PadLeft(length + padding / 2, symbol).PadRight(length + padding, symbol);
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
