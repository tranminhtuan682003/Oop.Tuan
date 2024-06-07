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
        /// Use again function InsertTable of the Database to insert a object Product into Datebase. 
        /// </summary>
        public void InsertProductTest(BaseRow obj)
        {
            Database.Instance.InsertTable(obj);
        }

        /// <summary>
        /// Use again function SelectTable of the Database to select a table Product. 
        /// </summary>
        public void SelectProductTest(string productName)
        {
            Database.Instance.SelectTable(productName);
        }

        /// <summary>
        /// Use again function UpdateTable of the Database to update a row in table Product equal id. 
        /// </summary>
        public void UpdateProductTest(BaseRow obj, int id)
        {
            Database.Instance.UpdateTable(obj, id);
        }

        /// <summary>
        /// Use again function PrintInforTable of the Database to Find table Product in the Database with input nameTable.
        /// </summary>
        public void FindProductTest(string productName)
        {
            Database.Instance.PrintInforTable(productName);
        }
    }
}
