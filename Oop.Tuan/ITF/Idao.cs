using Oop.Tuan.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Tuan
{
    public interface Idao
    {
        /// <summary>
        /// function Abstract InsertTable use for subclasses emplement.
        /// </summary>
        bool InsertTable(BaseRow obj);

        /// <summary>
        /// function Abstract UpdateTable use for subclasses emplement.
        /// </summary>
        void UpdateTable(BaseRow obj,int id);

        /// <summary>
        /// function Abstract SelectTable use for subclasses emplement.
        /// </summary>
        void SelectTable(string name);

        /// <summary>
        /// function Abstract DeleteAllRow use for subclasses emplement.
        /// </summary>
        void DeleteAllRow();

        /// <summary>
        /// function Abstract PrintInforTable use for subclasses emplement.
        /// </summary>
        void PrintInforTable(string name);
    }
}
