using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarytest.Math
{
    class Arithmetic
    {
        public int add(int a, int b)
    
          {
         return a + b;
        }
        public int add(int a, int b, int c)
{
    return a + b + c;
}
        public int add(int[i]a)
{

}
        public class Rectangle
        {
            public int length { get; set; }
            public int breadth { get; set; }
            public int perimeter { get { return 2*(length + breadth); } }
            public int Area { get { return length * breadth; } }
            public Rectangle  (int length, int breadth)
            {
                this.length = length;
                this.breadth = breadth;
            }
        }
        


}
