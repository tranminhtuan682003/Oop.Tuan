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
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseDemo demo = new DatabaseDemo();
            demo.InitDatabase();
            demo.PrintTableTest();
        }
    }
}
