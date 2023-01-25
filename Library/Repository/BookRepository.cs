using Library.Interface;
using Library.Model;
using System.Diagnostics.Contracts;

namespace Library.Repository
{
    public class BookRepository: IRepository
    {
        public HashSet<Book> Books { get; set; } = new HashSet<Book>
        {
            new Book { Id = 1, Title = "Mắt biết", Publisher = "Nhà Xuất Bản Trẻ", Year = 2020, Authors = "Nguyễn Nhật Ánh"},
            new Book { Id = 2, Title = "Đắc Nhân Tâm", Publisher = "Nhà Xuất Bản Tổng Hợp", Year = 2021, Authors = "Dale Carnegie"},
            new Book { Id = 3, Title = "Thao Túng Tâm Lý", Publisher = "Nhà Xuất Bản Dân Trí", Year = 2022, Authors = "Shannon Thomas"},
            new Book { Id = 4, Title = "Nhà Giả Kim", Publisher = "Nhà Xuất Bản Văn Học", Year = 2021, Authors = "Paulo Coelho"},
            new Book { Id = 5, Title = "Rừng Na Uy", Publisher = "Nhà Xuất Bản Hội Nhà Văn", Year = 2021, Authors = "Murakami Haruki"},
        };
        public Book Get(int id) => Books.SingleOrDefault(book => book.Id == id);

        public bool Delete(int id)
        {
            var book = Get(id);
            return book != null ? Books.Remove(book) : false;
        }
        public Book Create()
        {
            var max = Books.Max(b => b.Id);
            var book = new Book() { Id = ++max };
            return book;
        }
        public bool Add(Book book) => Books.Add(book);
        public bool Update(Book book)
        {
            var b = Get(book.Id);
            return b != null ? Books.Remove(b) && Books.Add(book) : false;
        }

    }
}
