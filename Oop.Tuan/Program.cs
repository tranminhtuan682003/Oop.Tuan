using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Demo;
using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan
{
    public class Program
    {
        static void Main(string[] args)
        {
            object database1 = Database.GetInstance();
            object database2 = Database.GetInstance();
            
            if (database2 == database1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
