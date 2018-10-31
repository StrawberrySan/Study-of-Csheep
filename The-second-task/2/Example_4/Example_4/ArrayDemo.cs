using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    /// <summary>
    /// 此程序演示数组和嵌套for循环的用法
    /// </summary>
    class ArrayDemo
    {
        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //声明长度为6的数组
            float[] elements = new float[6];
            //计数器变量
            int index;
            //临时变量
            float temp;
            Console.WriteLine("输入要尽心排序的6个浮点数值:");
            //For循环接受用户输入的值
            for(index=0;index<elements.Length;index++)
            {
                elements[index] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n已排序的数组：");
            //嵌套for循环对值进行比较
            for(index=0;index<elements.Length;index++)
            {
                for (int j = index + 1; j < elements.Length; j++)
                {
                    //如果值不以升序排序，就交换这些值
                    if(elements[index]>elements[j])
                    {
                        temp = elements[index];
                        elements[index] = elements[j];
                        elements[j] = temp;
                    }
                }
                Console.WriteLine(elements[index]);
            }
        }
    }
}
