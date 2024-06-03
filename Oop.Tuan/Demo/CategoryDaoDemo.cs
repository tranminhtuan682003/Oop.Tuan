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
    internal class CategoryDaoDemo
    {
        public Database database;
        public void InsertTest(BaseRow obj)
        {
            database.InsertTable(obj);
        }
        public void FindAllTest(string name)
        {
            database.SelectTable(name);
        }
        public void UpdateTest(BaseRow obj,int id)
        {
            database.UpdateTable(obj,id);
        }
    }
}
