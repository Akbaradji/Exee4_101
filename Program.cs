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
            Console.WriteLine("Stack = ");
            foreach (char c in st)
            {
                Console.WriteLine();
                st.Push('s');
                st.Push('t');
                st.Push('u');
                st.Push('v');
                Console.WriteLine("Stack after adding thow elements");
                foreach (char ch in st)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine("\nCount of elements in the Stack: "+st.Count);
                Console.WriteLine();
                Console.WriteLine("Pop a value!");
                st.Pop();
                Console.WriteLine("Current stack:");
                foreach (char ch in st)
            }
        }
    }
}