/* Интерфейс для функции сложения двух чисел - простейший. Конструкцию try/catch поместил сюда только из-за требований к заданию.
По той же причине использовался метод Parse чтобы намеренно создать исключительные ситуации. Опрератор goto реализовал с 
целью знакомства и организации подобия цикла. Не понял как можно реализовать метериал из скринкаста 10.1 от слова совсем.
Поэтому организовал свой логгер, выводящий требуемые сообщения в консоль. В скринкасте реализован паттерн проектирования?
Тут как бы понять основные сценарии использования делегатов, событий и нтерфейсов... Если что-то более менее работает, так
это большаярадость. */

using System;

namespace Final_task_10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа складывает два числа.");


            Sum ob = new Sum();
            var first_summand = ob.GetFirstSummand();
            var second_summand = ob.GetSecondSummand();

            ISum summ1 = new Sum();
            var summ = summ1.Sum(first_summand, second_summand);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nСумма числа {first_summand} и числа {second_summand} равна {summ}");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
