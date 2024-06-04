using Oop.Tuan.Base;
using Oop.Tuan.Dao;
using Oop.Tuan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Demo
{
    public class AccessoryDAO : BaseDao
    {
        public void InsertAccessory(BaseRow obj)
        {
            InsertTable(obj);
        }

        public void UpdateAccessory(BaseRow obj, int id)
        {
            UpdateTable(obj, id);
        }


        public void SelectAccessory(string Accessoryname)
        {
            SelectTable(Accessoryname);
        }

        public void PrintAccessory(string accessoryName)
        {
            PrintInforTable(accessoryName);
        }
    }
}
