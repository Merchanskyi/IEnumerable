using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableApp
{
    class Program
    {
        enum Days
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресение
        };

        static void Main(string[] args)
        {
            Console.WriteLine("*********Тема с Collections.Generic*********");
            var arrayList = new ArrayList();

            arrayList.Add(GetNumbers());
            arrayList.Add(GetWeek());
            arrayList.Add("228");
            arrayList.Add(1);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n*********Тема с днями*********");
            foreach (var day in Enum.GetValues(typeof(Days)))
                Console.WriteLine(day.ToString());

            Console.ReadKey();
        }

        private static IEnumerable<int> GetNumbers()
        {
            var number = 0;
            while (true)
            {
                if (number > 10)
                    yield break;

                yield return number++;
            }
        }

        private static object GetWeek()
        {
            const int week = 6;
            var num = 0;
            while (true)
            {
                if (num >= week)
                    break;

                num++;
            }
            return num;
        }
    }
}
