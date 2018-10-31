using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        class Tree
        {
            int height;
            public Tree()
            {
                Console.WriteLine("Planting a seedling");
                height = 0;
            }
            public Tree(int i)
            {
                Console.WriteLine("Creating new Tree that is " + i + " feet tall");
                height = i;
            }
            internal void info()
            {
                Console.WriteLine("Tree is " + height + " feet tall");
            }
            internal void info (string s)
            {
                Console.WriteLine(s + ":Tree is" + height + "feet tall");
            }
        }
        static void Main(string[] args)
        {
            for( int i= 0;i<5;i++)
            {
                Tree t = new Tree(i);
                t.info();
                t.info("overloaded method");
            }
            new Tree();
        }
    }
}
