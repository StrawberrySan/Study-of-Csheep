using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallConstructor
{
    public class Car
    {
        int petalCount = 0;
        string s = "null";
        Car(int petalCount)
        {
            this.petalCount = petalCount;//this的第一种用法
            Console.WriteLine("Constructor w/int arg only,petalCount=" + petalCount);
        }
        Car(String s, int petals)
            : this(petals)//this 关键字调用参数最匹配的那个构造函数
        {
            this.s = s;
            Console.WriteLine("String& int args");
        }
        Car() : this("hi", 47)
        {
            Console.WriteLine("default Constructor");
        }
        static void Main(string[] args)
        {
            Car x = new Car();
        }
    }
}
