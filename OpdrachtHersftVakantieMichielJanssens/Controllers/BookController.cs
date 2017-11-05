using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpdrachtHersftVakantieMichielJanssens.Models;

namespace OpdrachtHersftVakantieMichielJanssens.Controllers
{
    public class BookController : Controller
    {
        [HttpGet("/books")]
        public IActionResult Index()
        {
            var model = new BookListViewModel();
            model.Books = new List<BookDetailViewModel>();
            model.Books.Add(new BookDetailViewModel() { Author = "author 1", CreatedOn = DateTime.Now, ISBN = "isbn 1", Title = "title 1", Genre ="Horror" });
            model.Books.Add(new BookDetailViewModel() { Author = "author 2", CreatedOn = DateTime.Now, ISBN = "isbn 2", Title = "title 2", Genre = "Horror" });
            model.Books.Add(new BookDetailViewModel() { Author = "author 3", CreatedOn = DateTime.Now, ISBN = "isbn 3", Title = "title 3", Genre = "Horror" });
            model.Books.Add(new BookDetailViewModel() { Author = "author 4", CreatedOn = DateTime.Now, ISBN = "isbn 4", Title = "title 4", Genre = "Horror" });
            return View(model);
        }

        [HttpGet("/books/{id}")]
        public IActionResult Detail([FromRoute] int id)
        {
            return View();
        }
    }
}
