using System;
using System.Collections.Generic;

namespace OpdrachtHersftVakantieMichielJanssens.Models
{
    public class BookListViewModel
    {
        public List<BookDetailViewModel> Books { get; set; }
        public DateTime GeneratedAt => DateTime.Now;
    }
}