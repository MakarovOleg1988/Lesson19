using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var _array = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var _min = _array.Min();
            var _max = _array.Max();

            Console.Write(_min);
            Console.Write(_max);

            var _greatestFive = _array.First(t => t > 5); //Поиск первого значения отвечающего условию 
            var _lessFive = _array.Last(t => t < 5); // //Поиск первого значения с конца отвечающего условию

            var t = default(int);

            var _greatestFive2 = _array.FirstOrDefault(t => t > 50); //Аналогичный поиск, но при этом в случае неравенства условию выдает default значение
            var _lessFive2 = _array.LastOrDefault(t => t < -50);

            var _string = new List<string>(_array.Select(_element => _element.ToString())); // Выбор элементов массива и приобразование int в string через toString
            Console.Write(_string.Count);

            var _minString = _string.Min();
            var _maxString = _string.Max();

            Console.Write("\n");
            var _string1 = new List<string>(_array.Select(_element => Convert(_element))); // Аналогичный выбор через Convert и функцию Static string

            foreach (var el in _array)
            {
                _string.Add(el.ToString());
                Console.WriteLine(el);
            }


            var _test = new List<Test>();

            for (int i = 0; i <= 10; i++)
            {
                _test.Add(new Test { _value = i });
            }

            var _greatestFive3 = _test.FirstOrDefault(t => t._value > 5); 
            var _lessFive3 = _test.LastOrDefault(t => t._value < 5);

            var t1 = new List<int>(_array.Where(t => t > 5));
            var t2 = new List<int>(_array.Where(t => t < 5));
            var t3 = _array.Sum(t => t = 5);
        }

        public static string Convert(int t)
        {
            return t.ToString();
        }
    }

        public class Test
        {
            public int _value;
        }
}
