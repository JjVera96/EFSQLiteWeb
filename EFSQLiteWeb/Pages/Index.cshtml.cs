using EFSQLiteWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFSQLiteWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LibraryContext _context;
        public List<Author> authorList { get; set; } = new ();
        public List<Book> bookList { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger, LibraryContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            authorList =  _context.Authors.ToList();
            bookList =  _context.Books.ToList();
        }
    }
}