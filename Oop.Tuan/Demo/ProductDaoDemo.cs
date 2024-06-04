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
        public void InsertProductTest(BaseRow obj)
        {
            Database.GetInstance().InsertTable(obj);
        }

        public void SelectProductTest(string productName)
        {
            Database.GetInstance().SelectTable(productName);
        }

        public void UpdateProductTest(BaseRow obj, int id)
        {
            Database.GetInstance().UpdateTable(obj, id);
        }

        public void FindProductTest(string productName)
        {
            Database.GetInstance().PrintInforTable(productName);
        }
    }
}
