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
    public class IndexModel : PageModel
    {
        private readonly Proiect2_Medii_Ciprian_Hagau.Data.Proiect2_Medii_Ciprian_HagauContext _context;

        public IndexModel(Proiect2_Medii_Ciprian_Hagau.Data.Proiect2_Medii_Ciprian_HagauContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
