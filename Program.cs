/* Интерфейс для функции сложения двух чисел - простейший. Конструкцию try/catch поместил сюда только из-за требований к заданию.
По той же причине использовался метод Parse чтобы намеренно создать исключительные ситуации. Опрератор goto реализовал с 
целью знакомства и организации подобия цикла. Не понял как можно реализовать метериал из скринкаста 10.1 в данном задании, сохранив
при этом другой функционал. Поэтому организовал свой логгер (как метод), выводящий требуемые сообщения в консоль, не применяя интерфейс. 
Тут как бы понять основные сценарии использования делегатов, событий и интерфейсов... . */

using System;

namespace Final_task_10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа складывает два числа.");


            ISum num = new Sum();
            var first_summand = num.GetFirstSummand();
            var second_summand = num.GetSecondSummand();

            ISum summ1 = new Sum();
            var summ = summ1.Sum(first_summand, second_summand);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nСумма числа {first_summand} и числа {second_summand} равна {summ}");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
