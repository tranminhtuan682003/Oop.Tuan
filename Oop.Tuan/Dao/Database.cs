using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Oop.Tuan.Dao
{
    public class Database
    {
        private static readonly Lazy<Database> Lazy = new Lazy<Database>(() => new Database());
        //private static Database instance;

        /// <summary>
        /// sử dụng cấu trúc dữ liệu Dictionary để luuw trữ tên bảng và các hàng
        /// </summary>
        private Dictionary<string, List<BaseRow>> mydatabase;

        /// <summary>
        /// Hàm GetInstance tạo một thể hiện duy nhất của database để truy cập tới.
        /// </summary>

        //public static Database Instance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new Database();
        //    }
        //    return instance;
        //}
        public static Database Instance
        {
            get { return Lazy.Value; }
        }

        private Database()
        {
            mydatabase = new Dictionary<string, List<BaseRow>>();
        }
        /// <summary>
        /// hàm insertTable để thêm các bảng.
        /// obj : lấy tên các đối tượng con của baseRow làm tên bảng.
        /// </summary>
        public void InsertTable(BaseRow obj)
        {
            if (!mydatabase.ContainsKey(obj.GetType().Name))
            {
                mydatabase[obj.GetType().Name] = new List<BaseRow>();
            }
            mydatabase[obj.GetType().Name].Add(obj);
        }

        /// <summary>
        /// Hàm selecTable để lấy ra dang sách các hàng trong một bảng.
        /// name : truyền vào tên bảng.
        /// </summary>
        public List<BaseRow> SelectTable(string name)
        {
            if (!mydatabase.ContainsKey(name))
            {
                return null;
            }
            List<BaseRow> row = new List<BaseRow>();
            row = mydatabase[name];
            return row;
        }

        /// <summary>
        /// Hàm UpdateTable để thay đổi giá trị các thuộc tính của một dòng trong bảng.
        /// obj : để lấy tên bảng và cập nhật các giá trị thay đổi.
        /// id : tìm id có trong bảng. 
        /// </summary>
        public void UpdateTable(BaseRow obj, int id)
        {
            string key = obj.GetType().Name;
            if (mydatabase.ContainsKey(key))
            {
                int index = mydatabase[key].FindIndex(item => item.Id == id);
                if (index != -1)
                {
                    mydatabase[key][index] = obj;
                }
            }
        }

        /// <summary>
        /// Hàm DeleteTable xoá dòng trong bảng.
        /// name : truyền vào tên bảng.
        /// id : truyền vào id của dòng trong bảng để xoá dòng chứa id.
        /// </summary>
        public void DeleteTable(string name, int id)
        {
            foreach (BaseRow item in mydatabase[name])
            {
                if (item.Id == id)
                {
                    mydatabase[name].Remove(item);
                    return;
                }
            }
        }

        /// <summary>
        /// Hàm TruncateTable xoá toàn bộ các bảng có trong database.
        /// </summary>
        public void TruncateTable()
        {
            foreach (var item in mydatabase.Keys)
            {
                mydatabase[item].Clear();
            }
        }

        /// <summary>
        /// Hàm PrintMydatabase để in ra các thong tin của các bảng có trong database
        /// </summary>
        public void PrintMydatabase()
        {
            foreach (var typeItem in mydatabase.Keys)
            {
                foreach (var item in mydatabase[typeItem])
                {
                    item.Infor();
                }
            }
        }

        public void PrintInforTable(string tableName)
        {

            foreach(var item in mydatabase[tableName])
            {
                item.Infor();
            }
        }

        /// <summary>
        /// Hàm UpdateTableById để cập nhặt các dòng trong bảng bằng id truyền vào
        /// </summary>
        public void UpdateTableById(BaseRow obj, int id)
        {
            string key = obj.GetType().Name;
            if (mydatabase.ContainsKey(key))
            {
                int index = mydatabase[key].FindIndex(item => item.Id == id);
                if (index != -1)
                {
                    mydatabase[key][index] = obj;
                }
            }
        }

    }
}
