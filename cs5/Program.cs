using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Task 1 ==================");
            Employee em = new Employee("TestN", "TestS", 2000, "Developer");
            Employee em1 = new Employee("TestN", "TestS", 2000, "Developer");
            Department dep = new Department();
            dep.Add(em);
            dep.Add(em1);
            dep.Show();
            dep.Remove("estN", "t");
            dep.Show();

            Console.WriteLine();
            Console.WriteLine("Task 2 ==================");
            List<Shape> list = new List<Shape>();
            list.Add(new Circle(5));
            list.Add(new Rectangle(12, 23));
            list.Add(new Circle(2));
            list.Add(new Rectangle(22, 13));
            list.Add(new Circle(1));
            list.Add(new Rectangle(2, 5));
            list.Add(new Circle(6));
            list.Add(new Rectangle(1, 33));

            Console.WriteLine();
            Console.WriteLine("Ordered list");
            foreach (var el in list.OrderBy(e => e.Area))
                el.Print();

            var circles = list.FindAll(el => el.GetType().Name == "Circle");
            Console.WriteLine();
            Console.WriteLine("Circles list");
            foreach (var el in circles)
                el.Print();

            Console.WriteLine();
            Console.WriteLine("Rectangle 10-20");
            foreach (var el in list.Where(x => x.Area >= 10 && x.Area <= 20))
                el.Print();

            Console.WriteLine();
            Console.WriteLine("Rectangle 10-20");
            foreach (var el in (from shape in list where (shape.Area >= 10 && shape.Area <= 20) select shape))
                el.Print();

            Console.WriteLine();
            Console.Write("Max Rectangle area: ");
            Console.WriteLine((list.Where(x => x.GetType().Name == "Rectangle")).Max(x => x.Area));

            Console.WriteLine();
            Console.Write("Circles with area > 10: ");
            Console.WriteLine(list.Count(x => x.GetType().Name == "Circle" && x.Area > 10));

            Console.WriteLine();
            Console.WriteLine("Ordered circles and rectangles");
            foreach (var el in (list.FindAll(x=>x.GetType().Name == "Circle")).OrderBy(e => e.Area))
                el.Print();
            foreach (var el in (list.FindAll(x => x.GetType().Name == "Rectangle")).OrderBy(e => e.Area))
                el.Print();

            Console.WriteLine();
            Console.Write("Rectangle height collection: ");
            ArrayList al = new ArrayList();
            foreach (var el in list.FindAll(x => x.GetType().Name == "Rectangle"))
                al.Add((el as Rectangle)[0]);
            foreach (var el in al)
                Console.Write($"{el}  ");
        }
    }
}
