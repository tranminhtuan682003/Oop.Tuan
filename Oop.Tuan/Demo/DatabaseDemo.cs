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
            Database.Instance.InsertTable(obj);
        }

        public void SelectTableTest(string name)
        {
             Database.Instance.SelectTable(name);
        }

        public void UpdateTableTest(BaseRow obj,int id)
        {
            Database.Instance.UpdateTable(obj, id);
        }

        public void DeleteTableTest(string name,int id)
        {
            Database.Instance.DeleteTable(name,id);
        }

        public void TruncateTableTest()
        {
            Database.Instance.TruncateTable();
        }

        /// <summary>
        /// Hàm InitDatabase khởi tạo mỗi bảng 10 dòng.
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

        public void PrintTableTest()
        {
            Database.Instance.PrintMydatabase();
        }

        public void updateTableTest(BaseRow obj,int id)
        {
            Database.Instance.UpdateTableById(obj,id);
        }
    }
}
