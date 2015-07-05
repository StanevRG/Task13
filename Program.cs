using System;
using System.Collections.Generic;

namespace Task13
{
    class Program
    {
        static void Main(string[] args) {
            //  Функция EnterArray() возвращает заполненный в консоли пользователем массив чисел
            var valuesArr = EnterArray();
            //  Удаляем нулевые значения из массива
            valuesArr.RemoveAll(t => t == 0);
            //  Далее выводим информацию о проделанной работе пользователю в консоль
            Console.Write("Массив с удаленными нулевыми значениями: ");
            foreach (var value in valuesArr) {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
            Console.WriteLine("Спасибо! Нажмите кнопку для завершения программы.");
            Console.ReadKey();
        }

        /// <summary>
        /// Функция EnterArray() возвращает заполненный в консоли пользователем массив чисел
        /// </summary>
        /// <returns></returns>
        private static List<float> EnterArray() {
            Console.Write("Введите массив действительных чисел, разделенных пробелом: ");
            //  Получаем строку, предположительно, содержащую вечещственные числа, разделенные пробелами
            var str = Console.ReadLine();
            Console.WriteLine();
            //  Разбиваем строку на подстроки, каждая из которых предположительно содержит вещественное число
            var valuesStrArr = str.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //  Создаем исходный массив действительных чисел, ссылку на который функция вернет в переменную массива объявленную в методе Main()
            var result = new List<float>();
            //  Конвертируем введенные пользователем значения из строк во float
            foreach (var valueStr in valuesStrArr) {
                float value;
                float.TryParse(valueStr, out value);
                result.Add(value);
            }

            return result;
        }
    }
}
