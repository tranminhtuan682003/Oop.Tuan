namespace Oop.Tuan.Base
{
    public interface IEnity
    {
        int Id { get; set; }

        string Name { get; set; }

        /// <summary>
        /// function Abstract Infor use for subclasses emplement.
        /// </summary>
        void Infor();
    }
}