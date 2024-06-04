using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Entity;
namespace Oop.Tuan.Demo
{
    public class DatabaseDemo
    {
        /// <summary>
        ///  Class DatabaseDemo sử dụng lại các phương thức của Class Database
        /// </summary>
        public void InsertTableTest(BaseRow obj)
        {
            Database.GetInstance().InsertTable(obj);
        }

        public void SelectTableTest(string name)
        {
             Database.GetInstance().SelectTable(name);
        }

        public void UpdateTableTest(BaseRow obj,int id)
        {
            Database.GetInstance().UpdateTable(obj, id);
        }

        public void DeleteTableTest(string name,int id)
        {
            Database.GetInstance().DeleteTable(name,id);
        }

        public void TruncateTableTest()
        {
            Database.GetInstance().TruncateTable();
        }

        /// <summary>
        /// Hàm InitDatabase khởi tạo mỗi bảng 10 dòng.
        /// </summary>
        public void InitDatabase()
        {
            for(int i = 0; i < 10; i++)
            {
                Database.GetInstance().InsertTable(new Product(i, "product " + i, i));
                Database.GetInstance().InsertTable(new Category(i, "category " + i));
                Database.GetInstance().InsertTable(new Accessotion(i, "Accessotion " + i));
            }
        }

        public void PrintTableTest()
        {
            Database.GetInstance().PrintMydatabase();
        }

        public void updateTableTest(BaseRow obj,int id)
        {
            Database.GetInstance().UpdateTableById(obj,id);
        }
    }
}
