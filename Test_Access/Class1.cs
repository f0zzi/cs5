using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Access
{
    public class Paralelepiped : cs5.Rectangle
    {
        public Paralelepiped(int height_, int width_) : base(height_, width_) { }
    }
    public class Square : cs5.Rectangle
    {
        public Square(int side) : base(side, side) { }
    }
}
