using System;
using System.Collections.Generic;

namespace OpdrachtHersftVakantieMichielJanssens.Models
{
    public class BookListViewModel
    {
        public Dictionary<int, BookDetailViewModel> Books = new Dictionary<int, BookDetailViewModel>()
         {
             { 1, new BookDetailViewModel { Author = "Author 1", CreatedOn = DateTime.Now, ISBN = "isbn 1", Title = "title 1", Genre = "horror" }},
             { 2, new BookDetailViewModel { Author = "Author 2", CreatedOn = DateTime.Now, ISBN = "isbn 2", Title = "title 2", Genre = "horror" }},
             { 3, new BookDetailViewModel { Author = "Author 3", CreatedOn = DateTime.Now, ISBN = "isbn 3", Title = "title 3", Genre = "horror" }},
             { 4, new BookDetailViewModel { Author = "Author 4", CreatedOn = DateTime.Now, ISBN = "isbn 4", Title = "title 4", Genre = "horror" }},
         };
    }
}