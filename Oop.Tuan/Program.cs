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
            CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
            categoryDaoDemo.InsertTest(new Category(1, "category"));
            categoryDaoDemo.FindAllTest("Category");
            categoryDaoDemo.Print();
        }
    }
}
