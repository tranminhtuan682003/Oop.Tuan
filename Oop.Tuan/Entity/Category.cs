using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Entity
{
    public class Category : BaseRow
    {
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override void Infor()
        {
            base.Infor();
        }
    }
}

