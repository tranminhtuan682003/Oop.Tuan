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
        /// Uses the Dictionary data structure to store table names and rows
        /// </summary>
        private Dictionary<string, List<BaseRow>> mydatabase;

        /// <summary>
        /// The GetInstance function creates a single instance of the database to access.
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
        /// insertTable function to add tables.
        /// obj : get the names of baseRow's child objects as table names.
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
        /// SelectTable function to retrieve a list of rows in a table.
        /// name : pass in table name.
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
        /// UpdateTable function to change the attribute values ​​of a row in the table.
        /// obj : to get table name and update changed values.
        /// id : find id in the table.
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
        /// The DeleteTable function deletes rows in the table.
        /// name : pass in table name.
        /// id: pass the id of the row in the table to delete the row containing the id.
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
        /// The TruncateTable function deletes all tables in the database.
        /// </summary>
        public void TruncateTable()
        {
            foreach (var item in mydatabase.Keys)
            {
                mydatabase[item].Clear();
            }
        }

        /// <summary>
        /// PrintMydatabase function to print information of tables in the database
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

        /// <summary>
        /// PrintInforTable function to print information of a table in the Database.
        /// </summary>
        public void PrintInforTable(string tableName)
        {

            foreach(var item in mydatabase[tableName])
            {
                item.Infor();
            }
        }

        /// <summary>
        /// UpdateTableById function use to update an Object in the Databse with input id.
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
