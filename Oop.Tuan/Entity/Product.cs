using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Entity
{
    public class Product : BaseRow
    {
        private int categoryId {  get; set; }

        public Product(int id, string name, int categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.categoryId = categoryId;
        }

        public override void Infor()
        {
            base.Infor();
        }
    }
}
