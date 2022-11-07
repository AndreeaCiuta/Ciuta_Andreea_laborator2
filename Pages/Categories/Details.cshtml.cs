using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciuta_Andreea_laborator2.Data;
using Ciuta_Andreea_laborator2.Models;

namespace Ciuta_Andreea_laborator2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context _context;

        public DetailsModel(Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
