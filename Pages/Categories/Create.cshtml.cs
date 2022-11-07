﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ciuta_Andreea_laborator2.Data;
using Ciuta_Andreea_laborator2.Models;

namespace Ciuta_Andreea_laborator2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context _context;

        public CreateModel(Ciuta_Andreea_laborator2.Data.Ciuta_Andreea_laborator2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
