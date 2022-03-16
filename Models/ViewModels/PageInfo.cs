﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission11.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        // how many pages?
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage);
    }
}
