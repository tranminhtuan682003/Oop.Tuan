using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Entity
{
    internal class ProductDemo : BaseRow
    {
        private int categoryId {  get; set; }
        public ProductDemo(int id,string name,int categoryId) {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public override void Infor()
        {
            base.Infor();
        }
    }
}
