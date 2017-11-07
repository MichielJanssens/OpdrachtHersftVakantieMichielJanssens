﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpdrachtHersftVakantieMichielJanssens.Entities;

namespace OpdrachtHersftVakantieMichielJanssens.Models
{
    public class BookDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
