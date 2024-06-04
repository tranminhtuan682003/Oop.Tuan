using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Dao
{
    public abstract class BaseDao : Idao
    {
        /// <summary>
        /// 
        /// class BaseDao triển khai các phương thức trừu tượng của interface Idao
        /// 
        /// </summary>
        public bool InsertTable(BaseRow obj)
        {
            Database.GetInstance().InsertTable(obj);
            return true;
        }

        public void UpdateTable(BaseRow obj,int id)
        {
            Database.GetInstance().UpdateTable(obj,id);
        }

        public void SelectTable(string name)
        {
            Database.GetInstance().SelectTable(name);
        }

        public void DeleteAllRow()
        {
            Database.GetInstance().TruncateTable();
        }

        public void PrintInforTable(string tablename)
        {
            Database.GetInstance().PrintInforTable(tablename);
        }
    }
}
