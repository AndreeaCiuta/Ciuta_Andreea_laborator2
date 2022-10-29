using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciuta_Andreea_laborator2.Data;
using Ciuta_Andreea_laborator2.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.VisualStudio.Debugger.Contracts;
using System.Runtime.Intrinsics.X86;

namespace Ciuta_Andreea_laborator2.Pages.Books
{

    public class IndexModel : PageModel
    {
        private readonly Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context _context;

        public IndexModel(Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                   .Include(b => b.Publisher)
                   .Include(b => b.Author)
                   .ToListAsync();

        }
    }
}