using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DairyFarmWebApp.BusinessLayer;
using DairyFarmWebApp.Data;

namespace DairyFarmWebApp.Products
{
    public class EditModel : PageModel
    {
        private readonly DairyFarmWebApp.Data.DairyFarmDataContext _context;

        public EditModel(DairyFarmWebApp.Data.DairyFarmDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.StudentCourses
                .Include(p => p.Category)
                .Include(p => p.Company).FirstOrDefaultAsync(m => m.ProductID == id);

            if (Product == null)
            {
                return NotFound();
            }
           ViewData["CategoryID"] = new SelectList(_context.Courses, "CategoryID", "CategoryName");
           ViewData["CompanyID"] = new SelectList(_context.Students, "CompanyID", "CompanyName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.ProductID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(int id)
        {
            return _context.StudentCourses.Any(e => e.ProductID == id);
        }
    }
}
