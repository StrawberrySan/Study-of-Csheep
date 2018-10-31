using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    //学位枚举列表
    enum Degrees
    {
        //枚举成员
        Bachelor,
        Master,
        Docter
    }
    /// <summary>
    /// 此程序演示枚举和switch case的用法。
    /// </summary>
    class EnumDemo
    {
        static void Main(string[] args)
        {
            //用switch case 来为相应的case显示信息。
            switch (Degreess.Master)
            {
                case degress.Bachelor:
                    Console.WriteLine("你的学位为学士");
                    break;
                case degress.Master:
                    Console.WriteLine("你的学位为硕士");
                    break;
                case degress.Doctor:
                    Console.WriteLine("你的学位为博士");
                    break;
                default:break;
            }
            Console.ReadLine();
        }
    }
}
