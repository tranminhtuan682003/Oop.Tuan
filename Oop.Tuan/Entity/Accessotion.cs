using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Entity
{
    internal class Accessotion : BaseRow
    {
        public Accessotion(int id, string name)
        {
            this.id = id;
            this.name = name;
            typeName = "Accessotion";
        }

        public override void Infor()
        {
            base.Infor();
        }
    }
}
