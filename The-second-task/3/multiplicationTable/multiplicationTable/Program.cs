using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<10;i++)
            {
                //输出一行
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j.ToString() + "*" + i.ToString() + ";");
                }
                Console.Write("\n");//换行
            }
        }
    }
}
