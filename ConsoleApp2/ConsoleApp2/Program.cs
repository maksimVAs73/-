using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное целое число:");

            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input); // Попытка преобразовать строку в число

                if (number <= 0)
                {
                    throw new ArgumentException("Число должно быть положительным."); //Выбрасываем исключение, если число не положительное
                }

                Console.WriteLine($"Вы ввели число: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода.  Введите целое число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}
