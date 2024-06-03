using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Dao
{
    internal class CategoryDAO
    {
        public Database database;
        public bool InsertCategory()
        {
            database.InsertTable(new Category(1001, "Orion"));
            return true;
        }
    }
}
