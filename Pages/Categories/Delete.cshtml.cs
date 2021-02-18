using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect2_Medii_Ciprian_Hagau.Data;
using Proiect2_Medii_Ciprian_Hagau.Models;

namespace Proiect2_Medii_Ciprian_Hagau.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect2_Medii_Ciprian_Hagau.Data.Proiect2_Medii_Ciprian_HagauContext _context;

        public DeleteModel(Proiect2_Medii_Ciprian_Hagau.Data.Proiect2_Medii_Ciprian_HagauContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
