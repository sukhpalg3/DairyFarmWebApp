﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly DairyFarmWebApp.Data.DairyFarmDataContext _context;

        public IndexModel(DairyFarmWebApp.Data.DairyFarmDataContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Students.ToListAsync();
        }
    }
}
