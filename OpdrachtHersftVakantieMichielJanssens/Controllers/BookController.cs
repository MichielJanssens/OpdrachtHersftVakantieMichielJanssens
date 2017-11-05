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

        public BookController()
        {
        }

        [HttpGet("/books")]
        public IActionResult Index()
        {
            var model = new BookListViewModel();

            return View(model);
        }

        [HttpGet("/books/{id}")]
        public IActionResult Detail([FromRoute] int id)
        {
            var model = new BookListViewModel().Books[id];

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
