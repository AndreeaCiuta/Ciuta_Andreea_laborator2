using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciuta_Andreea_laborator2.Data;
using Ciuta_Andreea_laborator2.Models;

namespace Ciuta_Andreea_laborator2.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private readonly Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context _context;

        public DeleteModel(Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);

            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }
            var author = await _context.Author.FindAsync(id);

            if (author != null)
            {
                Author = author;
                _context.Author.Remove(Author);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
