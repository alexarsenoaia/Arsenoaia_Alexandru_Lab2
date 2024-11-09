﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Arsenoaia_Alexandru_Lab2.Data;
using Arsenoaia_Alexandru_Lab2.Models;

namespace Arsenoaia_Alexandru_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Arsenoaia_Alexandru_Lab2.Data.Arsenoaia_Alexandru_Lab2Context _context;

        public IndexModel(Arsenoaia_Alexandru_Lab2.Data.Arsenoaia_Alexandru_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
