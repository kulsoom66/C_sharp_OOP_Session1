using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.oop
{
    internal class Child : Parent
    {
        public int z { get; set; }

        public Child(int _x, int _y, int _z):base(_x, _y)
        {
            z = _z;
        }

        public override string ToString()
        {
            return $"{x}, {y}, {z}";
        }

        public new int Product() //why not override?
        {
            return x * y * z;
            // return base.Product()*z; فنان

        }
    }
}
