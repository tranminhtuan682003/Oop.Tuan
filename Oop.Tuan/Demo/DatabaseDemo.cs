using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Entity;
namespace Oop.Tuan.Demo
{
    public class DatabaseDemo
    {
        /// <summary>
        /// Use again function InsertTable of the Database to insert an object into Datebase. 
        /// </summary>
        public void InsertTableTest(BaseRow obj)
        {
            Database.Instance.InsertTable(obj);
        }

        /// <summary>
        /// Use again function SelectTable of the Database to select a table Category with input nameTable. 
        /// </summary>
        public void SelectTableTest(string name)
        {
             Database.Instance.SelectTable(name);
        }

        /// <summary>
        /// Use again function UpdateTable of the Database to update an Object equal id. 
        /// </summary>
        public void UpdateTableTest(BaseRow obj,int id)
        {
            Database.Instance.UpdateTable(obj, id);
        }

        /// <summary>
        /// Use again function DeleteTable of the Database to delete an Object equal id. 
        /// </summary>
        public void DeleteTableTest(string name,int id)
        {
            Database.Instance.DeleteTable(name,id);
        }

        /// <summary>
        /// Use again function TruncateTable of the Database to delete all table. 
        /// </summary>
        public void TruncateTableTest()
        {
            Database.Instance.TruncateTable();
        }

        /// <summary>
        /// Function InitDatabase used to initialization a table with 10 row.
        /// </summary>
        public void InitDatabase()
        {
            for(int i = 0; i < 10; i++)
            {
                Database.Instance.InsertTable(new Product(i, "product " + i, i));
                Database.Instance.InsertTable(new Category(i, "category " + i));
                Database.Instance.InsertTable(new Accessotion(i, "Accessotion " + i));
            }
        }

        /// <summary>
        /// Function PrintTableTest used to print all table in the Database.
        /// </summary>
        public void PrintTableTest()
        {
            Database.Instance.PrintMydatabase();
        }

        /// <summary>
        /// Function updateTableTest used to update an Object with input id..
        /// </summary>
        public void updateTableTest(BaseRow obj,int id)
        {
            Database.Instance.UpdateTableById(obj,id);
        }
    }
}
