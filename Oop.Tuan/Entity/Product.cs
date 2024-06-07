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

        /// <summary>
        /// Constractor of class Product
        /// </summary>
        public Product(int id, string name, int categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.categoryId = categoryId;
        }

        /// <summary>
        ///  Product override function of Base to deploy it its way
        /// </summary>
        public override void Infor()
        {
            Console.WriteLine("categoryId : " + categoryId);
            base.Infor();
        }
    }
}
