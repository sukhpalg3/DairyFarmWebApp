using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DairyFarmWebApp.BusinessLayer;
using DairyFarmWebApp.Data;

namespace DairyFarmWebApp.Products
{
    public class CreateModel : PageModel
    {
        private readonly DairyFarmWebApp.Data.DairyFarmDataContext _context;

        public CreateModel(DairyFarmWebApp.Data.DairyFarmDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryID"] = new SelectList(_context.Courses, "CategoryID", "CategoryName");
        ViewData["CompanyID"] = new SelectList(_context.Students, "CompanyID", "CompanyName");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StudentCourses.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
