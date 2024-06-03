using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Demo
{
    internal class DatabaseDemo : Database
    {
        public void InsertTableTest()
        {
            base.InsertTable(new Product(1,"fff",3));
        }
        public void SelectTableTest()
        {
            base.SelectTable("Product");
        }
        public void UpdateTableTest()
        {
            base.UpdateTable(new Product(1, "fff", 4), 2);
        }
        public void DeleteTableTest()
        {
            base.DeleteTable("Product", 2);
        }
        public void TruncateTableTest()
        {
            base.TruncateTable();
        }
        public void InitDatabase()
        {
            for(int i = 0; i < 10; i++)
            {
                base.InsertTable(new Product(i, "product " + i, i));
                base.InsertTable(new Category(i, "category " + i));
                base.InsertTable(new Accessotion(i, "Accessotion " + i));
            }
        }
        public void PrintTableTest()
        {
            base.PrintMydatabase();
        }
        public void updateTableTest()
        {
            base.UpdateTableById(new Product(1, "fff", 4),1);
        }
    }
}
