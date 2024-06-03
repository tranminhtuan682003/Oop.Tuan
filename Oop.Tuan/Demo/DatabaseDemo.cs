using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Entity;
namespace Oop.Tuan.Demo
{
    internal class DatabaseDemo : Database
    {
        public void InsertTableTest(BaseRow obj)
        {
            InsertTable(obj);
        }
        public void SelectTableTest(string name)
        {
            SelectTable(name);
        }
        public void UpdateTableTest(BaseRow obj,int id)
        {
            UpdateTable(obj, id);
        }
        public void DeleteTableTest(string name,int id)
        {
            DeleteTable(name,id);
        }
        public void TruncateTableTest()
        {
            TruncateTable();
        }
        public void InitDatabase()
        {
            for(int i = 0; i < 10; i++)
            {
                InsertTable(new Product(i, "product " + i, i));
                InsertTable(new Category(i, "category " + i));
                InsertTable(new Accessotion(i, "Accessotion " + i));
            }
        }
        public void PrintTableTest()
        {
            PrintMydatabase();
        }
        public void updateTableTest(BaseRow obj,int id)
        {
            UpdateTableById(obj,id);
        }
    }
}
