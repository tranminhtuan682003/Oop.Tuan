using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Entity
{
    public class ProductDemo : BaseRow
    {
        /// <summary>
        /// categoryId thuộc tính riêng của đối tượng Product 
        /// </summary>
        private int categoryId {  get; set; }

        /// <summary>
        /// ProductDemo hàm khởi tạo
        /// </summary>
        public ProductDemo(int id,string name,int categoryId) {
            this.Id = id;
            this.Name = name;
            this.categoryId = categoryId;
        }

        /// <summary>
        /// thể h
        /// </summary>
        public override void Infor()
        {
            base.Infor();
        }
    }
}
