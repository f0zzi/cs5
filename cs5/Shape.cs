using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs5
{
    public abstract class Shape
    {
        //o Визначити у класі абстрактну властивість для читання Area(обчислення площі фігури)
        public abstract double Area { get; }
        //o Визначити у класі віртуальний метод Print() , вивести назву фігури(this.GetType().Name ) та її площу(Area).
        public virtual void Print()
        {
            Console.WriteLine($"Shape: {this.GetType().Name, -15} Area: {Math.Round(Area, 2)}");
        }
    }
    public class Circle : Shape
    {
        public Circle(int radius_) { radius = radius_; }
        //o Визначити у класі поле radius
        int radius;

        //o Реалізувати у класі віртуальну властивість для читання Area(повернути ).
        public override double Area { get => radius * radius * Math.PI; }
    }
    public class Rectangle : Shape
    {
        public Rectangle(int height_, int width_) { height = height_; width = width_; }
        //o Визначити у класі поля висота та ширина.
        int height, width;
        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return height;
                if (index == 1)
                    return width;
                throw new Exception("Invalid index");
            }
        }
        //o Реалізувати у класі віртуальну властивість для читання Area (ширина* висота).
        public override double Area { get => height * width; }
    }
}
