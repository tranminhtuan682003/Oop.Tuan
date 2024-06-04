using Oop.Tuan.Base;
using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Dao
{
    public class CategoryDAO : BaseDao
    {
        /// <summary>
        /// Hàm InsertCategory để insert đối tượng Category vào database
        /// </summary>
        public void InsertCategory(BaseRow obj)
        {
            InsertTable(obj);
        }

        public void UpdateCategory(BaseRow obj, int id)
        {
            UpdateTable(obj, id);
        }

        public void SelectCategory(string Categoryname)
        {
            SelectTable(Categoryname);
        }

        public void PrintCategory(string CategoryName)
        {
            PrintInforTable(CategoryName);
        }
    }
}
