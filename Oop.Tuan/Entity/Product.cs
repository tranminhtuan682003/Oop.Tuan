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
        /// <summary>
        /// categoryId thuộc tính riêng của Product 
        /// </summary>
        private int categoryId {  get; set; }

        /// <summary>
        /// hàm khởi tạo của class Product
        /// </summary>
        public Product(int id, string name, int categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.categoryId = categoryId;
        }

        /// <summary>
        /// Product override hàm Infor của Base để thể hiện tính đa hình của mình
        /// </summary>
        public override void Infor()
        {
            Console.WriteLine("categoryId : " + categoryId);
            base.Infor();
        }
    }
}
