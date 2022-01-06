using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_task_10._5
{
    public class Sum : ISum
    {
        int x;
        int y;

        public delegate void Error_Delegate(string message);
        public delegate void Event_Delegate(string message);


        public int GetFirstSummand()
        {
            Console.WriteLine("\nВведите первое слагаемое:");
        mark1:
            try
            {
                string input = Console.ReadLine();
                Event_Delegate event_delegate = new Event_Delegate(EventMessage);
                event_delegate(input);
                x = int.Parse(input);
            }
            catch (FormatException exc)
            {
                Error_Delegate error_delegate = new(ErrorMessage);
                error_delegate(exc.Message);

                Console.WriteLine("\nВведите первое слагаемое еще раз:");
                goto mark1;
            }
            catch (OverflowException exc)
            {
                Error_Delegate error_delegate = new(ErrorMessage);
                error_delegate(exc.Message);

                Console.WriteLine("\nВведите первое слагаемое еще раз:");
                goto mark1;
            }
            return x;
        }

        public int GetSecondSummand()
        {
            Console.WriteLine("\nВведите второе слагаемое:");
        mark2:
            try
            {
                string input = Console.ReadLine();
                Event_Delegate event_delegate = new Event_Delegate(EventMessage);
                event_delegate(input);
                y = int.Parse(input);
            }
            catch (FormatException exc)
            {
                Error_Delegate error_delegate = new(ErrorMessage);
                error_delegate(exc.Message);

                Console.WriteLine("\nВведите второе слагаемое еще раз:");
                goto mark2;
            }
            catch (OverflowException exc)
            {
                Error_Delegate error_delegate = new(ErrorMessage);
                error_delegate(exc.Message);

                Console.WriteLine("\nВведите второе слагаемое еще раз:");
                goto mark2;
            }
            return y;
        }

        int ISum.Sum(int x, int y)
        {
            return (x + y);
        }

        public static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nПроизошла ошибка: {message}");
            Console.ResetColor();
        }

        public void EventMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nВы ввели: {message}");
            Console.ResetColor();
        }

    }
}
