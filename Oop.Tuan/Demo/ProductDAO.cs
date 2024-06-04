using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Demo
{
    public class ProductDAO : BaseDao
    {
        public void InsertProduct(BaseRow obj)
        {
            InsertTable(obj);
        }

        public void UpdateProduct(BaseRow obj, int id)
        {
            UpdateTable(obj, id);
        }

        public void SelectProduct(string name)
        {
            SelectTable(name);
        }

        public void PrintProduct(string productName)
        {
            PrintInforTable(productName);
        }
    }
}
