using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.oop
{
    internal class Parent
    {
        public int x { get; set; }
        public int y { get; set; }

        public Parent(int _x, int _y)
        {
            this.x = _x; this.y = _y;
        }

        public int Product()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
}
