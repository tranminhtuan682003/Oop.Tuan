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
        /// function InsertTable emplement function abstract of interface used to insert an Object into database.
        /// </summary>
        public bool InsertTable(BaseRow obj)
        {
            Database.Instance.InsertTable(obj);
            return true;
        }

        /// <summary>
        /// function UpdateTable emplement function abstract of interface used to Update information an Object.
        /// </summary>
        public void UpdateTable(BaseRow obj,int id)
        {
            Database.Instance.UpdateTable(obj,id);
        }

        /// <summary>
        /// function SelectTable emplement function abstract of interface used to select a table in Database.
        /// </summary>
        public void SelectTable(string name)
        {
            Database.Instance.SelectTable(name);
        }

        /// <summary>
        /// function DeleteAllRow emplement function abstract of interface used to delete all row of a table in Database.
        /// </summary>
        public void DeleteAllRow()
        {
            Database.Instance.TruncateTable();
        }


        /// <summary>
        /// function PrintInforTable emplement function abstract of interface used to print information of a table in Database.
        /// </summary>
        public void PrintInforTable(string tablename)
        {
            Database.Instance.PrintInforTable(tablename);
        }
    }
}
