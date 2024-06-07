using System;
namespace Oop.Tuan.Base
{
    public abstract class BaseRow : IEnity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// virtual function used for overriding the children's class to print their information.
        /// </summary>
        public virtual void Infor()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
        }
    }
}
