using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DairyFarmWebApp.BusinessLayer;
using DairyFarmWebApp.Data;

namespace DairyFarmWebApp.Companies
{
    public class DeleteModel : PageModel
    {
        private readonly DairyFarmWebApp.Data.DairyFarmDataContext _context;

        public DeleteModel(DairyFarmWebApp.Data.DairyFarmDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Students.FirstOrDefaultAsync(m => m.CompanyID == id);

            if (Company == null)
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

            Company = await _context.Students.FindAsync(id);

            if (Company != null)
            {
                _context.Students.Remove(Company);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
