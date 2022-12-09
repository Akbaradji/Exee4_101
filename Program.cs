using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Example
    {
        static void Main(string[] args)
        {
            Stack st = Stack();
            st.Push('w');
            st.Push('x');
            st.Push('y');
            Console.WriteLine("Count of elements in the Current Stack: "+st.Count);
        }
    }
}