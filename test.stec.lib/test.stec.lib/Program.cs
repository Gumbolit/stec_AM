using System;
using System.Collections.Generic;
using Stec;

namespace test.stec.lib
{
    public class Test
    {
        public void check_for_emptiness_head()
        {
            funchan<int> item = new ttt<int>();
            Console.WriteLine(item.show_head());
        }
        public void check_for_emptiness_get()
        {
            funchan<int> item = new ttt<int>();
            Console.WriteLine(item.Get());
        }
        public void out_of_stack()
        {
            funchan<int> item = new ttt<int>();
            int a = 5;
            item.Add(a);
            Console.WriteLine(item.Get());
            Console.WriteLine(item.Get());
        }
        public void procedure()
        {
            funchan<int> item = new ttt<int>();
            int a = 1;
            Console.WriteLine("entered data");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
                item.Add(a);
                a++;
            }
            Console.WriteLine("data from the stack");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(item.Get());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test first = new Test();
            first.out_of_stack();
            first.procedure();
            
        }
    }
}
