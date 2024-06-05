namespace Oop.Tuan.Base
{
    public interface IEnity
    {
        /// <summary>
        /// Các thuộc tính Id và Name của các đối tượng Product, Category, Accession.
        /// </summary>
        int Id { get; set; }

        string Name { get; set; }

        /// <summary>
        /// Hàm trừu tượng Infor để in ra thông tin của các đối tượng.
        /// </summary>
        void Infor();
    }
}