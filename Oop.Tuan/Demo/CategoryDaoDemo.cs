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
        /// Use again function InsertTable of the Database to insert a object Category into Datebase. 
        /// </summary>
        public void InsertCategoryTest(BaseRow obj)
        {
            Database.Instance.InsertTable(obj);
        }

        /// <summary>
        /// Use again function SelectTable of the Database to select a table Category. 
        /// </summary>
        public void SelectCategoryTest(string categoryName)
        {
            Database.Instance.SelectTable(categoryName);
        }

        /// <summary>
        /// Use again function UpdateTable of the Database to update a row in table Category equal id. 
        /// </summary>
        public void UpdateCategoryTest(BaseRow obj, int id)
        {
            Database.Instance.UpdateTable(obj, id);
        }

        /// <summary>
        /// Use again function PrintInforTable of the Database to Find table Category in the Database with input nameTable.
        /// </summary>
        public void FindCategoryTest(string categoryName)
        {
            Database.Instance.PrintInforTable(categoryName);
        }
    }
}
