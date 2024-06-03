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
    internal class CategoryDaoDemo : Database
    {
        public void InsertTest(BaseRow obj)
        {
            InsertTable(obj);
        }
        public void FindAllTest(string name)
        {
            SelectTable(name);
        }
        public void UpdateTest(BaseRow obj,int id)
        {
           UpdateTable(obj,id);
        }
        public void Print()
        {
            PrintMydatabase();
        }
    }
}
