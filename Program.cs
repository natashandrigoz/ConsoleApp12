using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// Создание коллекции List<T> целых чисел и 
    /// некоторые методы для работы с коллекцией
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод вывода коллекции
        /// </summary>
        /// <param name="ints"></param>
        static void Output(List<int>ints)
        {
            foreach (int element in ints)
            {
                Console.Write($"{element}\t");
            }
        }
        /// <summary>
        /// Метод  для работы с элементами коллекции
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //1.Создание пустой коллекции
            //List<int> ints = new List<int>();
            var ints = new List<int>();
            //2.Добавление элементов в коллекцию
            ints.Add(1);
            ints.Add(10);
            ints.Add(25);
            ints.Add(17);
            ints.Add(10);
            foreach(int element in ints)
            {
                Console.Write($"{element}\t");
            }
            Console.WriteLine();
            //3. Вставка элемента по указанному индексу (сдвиг вправо)
            ints.Insert(0, 500);
            Output(ints);
            Console.WriteLine();
            //4. Добавление в конец списка элементов одномерного массива
            ints.AddRange(new[] {-4,0,18,-3});
            Output(ints);
            Console.WriteLine();
            //5. Определение количества элементов коллекции
            int size = ints.Count;
            Console.WriteLine($"Текущее количество элементов в списке = {size}");
            //7. Удаление из коллекции первого вхождения элемента 10
            ints.Remove(10);
            Output(ints);
            Console.WriteLine();
            //8. Метод удаления из коллекции элемента с указанным индексом
            ints.RemoveAt(2);
            Output(ints);
            Console.WriteLine();
            //9. Сортировка коллекции по возрастанию
            ints.Sort();
            Output(ints);
            Console.WriteLine();
            //10. Сортировка коллекции по убыванию
            ints.Reverse();
            Output(ints);
            Console.ReadKey();
        }
    }
}
