using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Demo
{
    public class ProductDaoDemo
    {
        /// <summary>
        /// ProductDaoDemo sử dụng lại các phương thức của Database và dùng Product làm row. 
        /// </summary>
        public void InsertProductTest(BaseRow obj)
        {
            Database.Instance.InsertTable(obj);
        }

        public void SelectProductTest(string productName)
        {
            Database.Instance.SelectTable(productName);
        }

        public void UpdateProductTest(BaseRow obj, int id)
        {
            Database.Instance.UpdateTable(obj, id);
        }

        public void FindProductTest(string productName)
        {
            Database.Instance.PrintInforTable(productName);
        }
    }
}
