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
        /// <summary>
        /// hàm khởi tạo của class Category
        /// </summary>
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Category triển khai lại phương thức Infor theo cách riêng của mình
        /// </summary>
        public override void Infor()
        {
            base.Infor();
        }
    }
}

