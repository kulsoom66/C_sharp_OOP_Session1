using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct struct1
    {
        // 1. Attirbutes
        public int x;
        public int y;
        // 2. Constructor: is a special function
        //      a. [Named alwayas with the same name of its struct or class]
        //      b. has no return type
        public struct1(int _x, int _y) {
            this.x = _x; //default x = 0
            this.y = _y; //default y = 0
        }

        // by defualt at struct, compilar will always generate paramterless constructor
        // that will initialize the attributes of struct with the default value of attribute datatype

        public override string ToString()
        {
            //return base.ToString(); //Namespace.DatatypeName
            return $"({x} , {y})";
        }
            
    }

}
