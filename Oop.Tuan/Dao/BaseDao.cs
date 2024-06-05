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
            Database.Instance.InsertTable(obj);
            return true;
        }

        public void UpdateTable(BaseRow obj,int id)
        {
            Database.Instance.UpdateTable(obj,id);
        }

        public void SelectTable(string name)
        {
            Database.Instance.SelectTable(name);
        }

        public void DeleteAllRow()
        {
            Database.Instance.TruncateTable();
        }

        public void PrintInforTable(string tablename)
        {
            Database.Instance.PrintInforTable(tablename);
        }
    }
}
