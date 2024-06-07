using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan.Entity
{
    public class Accessotion : BaseRow
    {
        /// <summary>
        /// Constractor of class Accessory
        /// </summary>
        public Accessotion(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Accessotion override function of Base to deploy it its way
        /// </summary>
        public override void Infor()
        {
            base.Infor();
        }
    }
}
