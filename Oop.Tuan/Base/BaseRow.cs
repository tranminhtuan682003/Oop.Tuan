using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Base
{
    internal class BaseRow
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeName { get; set; }
        public virtual void Infor()
        {
            Console.WriteLine("Id = " + id);
            Console.WriteLine("Name = " + name);
        }
    }
}
