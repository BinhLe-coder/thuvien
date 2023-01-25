using Library.Model;
using Library.Interface;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;
        public HashSet<Book> Books => _repository.Books;
        public int Count => _repository.Books.Count;
        public IndexModel(IRepository repository) => _repository = repository;
    }
}