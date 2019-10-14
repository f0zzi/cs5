using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs5;

namespace Test_Access
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Task 3 ==================");
            List<Shape> list = new List<Shape>();
            list.Add(new Square(5));
            list.Add(new Paralelepiped(12, 23));
            list.Add(new Square(2));
            list.Add(new Paralelepiped(22, 13));
            list.Add(new Square(1));
            list.Add(new Paralelepiped(2, 5));
            list.Add(new Square(6));
            list.Add(new Paralelepiped(1, 33));
            foreach (var el in list)
                el.Print();
            //o Перевірити чи всі фігури мають площу більшу 10(All())
            Console.WriteLine($"All > 10:\t{list.All(x => x.Area > 10)}");
            //o Перевірити чи є хоч один паралелепіпед з площею більше 100(Any())
            Console.WriteLine($"Any Par > 100:\t{list.Where(x => x.GetType().Name == "Paralelepiped").Any(x => x.Area > 100)}");
            //o Знайти перший з прямокутників, у якого площа менша 20(First())
            try
            {
                Console.Write($"First Par < 20:\t");
                list.First(x => x.Area < 20).Print();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            //o Знайти останній з прямокутників, у якого площа менша 20(Last()
            try
            {
                Console.Write($"Last Par < 20:\t");
                list.Last(x => x.Area < 20).Print();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
