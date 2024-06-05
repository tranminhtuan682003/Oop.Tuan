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
            Database database = Database.Instance;

            Console.WriteLine("truoc khi khoi tao : ");

            DatabaseDemo databasedemo = new DatabaseDemo();
            databasedemo.InitDatabase();

            Console.WriteLine("sau khi khoi tao : ");

            database.InsertTable(new Category(10, "tuan"));
            database.UpdateTable(new Category(11, "noname"), 10);
            database.DeleteTable("Category", 11);
            database.TruncateTable();
            database.PrintMydatabase();
            //database.PrintInforTable("Category");
        }
    }
}
