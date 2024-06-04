using System;
namespace Oop.Tuan.Base
{
    public abstract class BaseRow : IEnity
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual void Infor()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
        }
    }
}
