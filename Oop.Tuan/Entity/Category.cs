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
        /// Constractor of classCategory
        /// </summary>
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Category override function of Base to deploy it its way
        /// </summary>
        public override void Infor()
        {
            base.Infor();
        }
    }
}

