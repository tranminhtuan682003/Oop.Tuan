using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan
{
    public interface Idao
    {
        /// <summary>
        /// Tạo các phương thức trừu trượng cho các lớp Dao
        /// </summary>

        bool InsertTable(BaseRow obj);

        void UpdateTable(BaseRow obj,int id);

        void SelectTable(string name);

        void DeleteAllRow();

        void PrintInforTable(string name);
    }
}
