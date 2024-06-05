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
    public class CategoryDaoDemo
    {
        /// <summary>
        /// CategoryDaoDemo sử dụng lại các phương thức của Database và dùng Category làm row.
        /// </summary>
        public void InsertCategoryTest(BaseRow obj)
        {
            Database.Instance.InsertTable(obj);
        }

        public void SelectCategoryTest(string productName)
        {
            Database.Instance.SelectTable(productName);
        }

        public void UpdateCategoryTest(BaseRow obj, int id)
        {
            Database.Instance.UpdateTable(obj, id);
        }

        public void FindCategoryTest(string productName)
        {
            Database.Instance.PrintInforTable(productName);
        }
    }
}
