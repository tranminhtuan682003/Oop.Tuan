using Oop.Tuan.Base;
using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Dao
{
    internal class CategoryDAO : Database
    {
        public bool InsertCategory(BaseRow obj)
        {
            InsertTable(obj);
            return true;
        }
    }
}
