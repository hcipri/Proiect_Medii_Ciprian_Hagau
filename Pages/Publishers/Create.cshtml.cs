﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect2_Medii_Ciprian_Hagau.Data;
using Proiect2_Medii_Ciprian_Hagau.Models;

namespace Proiect2_Medii_Ciprian_Hagau.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Proiect2_Medii_Ciprian_Hagau.Data.Proiect2_Medii_Ciprian_HagauContext _context;

        public CreateModel(Proiect2_Medii_Ciprian_Hagau.Data.Proiect2_Medii_Ciprian_HagauContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
