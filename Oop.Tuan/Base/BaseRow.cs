using System;
namespace Oop.Tuan.Base
{
    public abstract class BaseRow : IEnity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// hàm ảo Infor dùng cho các lớp con thể hiện tính đa hình của chúng
        /// </summary>
        public virtual void Infor()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
        }
    }
}
