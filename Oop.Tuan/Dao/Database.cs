using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Dao
{
    internal class Database
    {

        public Dictionary<string, List<BaseRow>> mydatabase = new Dictionary<string,List<BaseRow>>();
        public void InsertTable(BaseRow obj)
        {
            if (!mydatabase.ContainsKey(obj.typeName))
            {
                mydatabase[obj.typeName] = new List<BaseRow>();
            }
            mydatabase[obj.typeName].Add(obj);
        }
        public List<BaseRow> SelectTable(string name)
        {
            if (!mydatabase.ContainsKey(name))
            {
                Console.WriteLine("Dot");
                return null;
            }
            else
            {
                List<BaseRow> row = new List<BaseRow>();
                row = mydatabase[name];
                return row;
            }
            
        }
        public void UpdateTable(BaseRow obj, int id)
        {
            foreach(BaseRow item in mydatabase[obj.typeName])
            {
                if(item.id == id)
                {
                    int position = mydatabase[obj.typeName].IndexOf(item);
                    mydatabase[obj.typeName][position] = obj;
                }
            }
        }
        public void DeleteTable(string name, int id)
        {
            foreach(BaseRow item in mydatabase[name])
            {
                if(item.id == id)
                {
                    mydatabase[name].Remove(item);
                    return;
                }
            }
        }
        public void TruncateTable()
        {
            foreach(var item in mydatabase.Keys)
            {
                mydatabase[item].Clear();
            }
        }
        public void PrintMydatabase()
        {
            foreach(var typeItem in mydatabase.Keys)
            {
                foreach(var item in mydatabase[typeItem])
                {
                    item.Infor();
                }
            }
        }
        public void UpdateTableById(BaseRow obj ,int id)
        {
            foreach (BaseRow item in mydatabase[obj.typeName])
            {
                if (item.id == id)
                {
                    int position = mydatabase[obj.typeName].IndexOf(item);
                    mydatabase[obj.typeName][position] = obj;
                }
            }
        }
    }
}
