using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Valor.Models;

namespace ValorOil.Pages.Wells
{
    public class AddReportModel : PageModel
    {
        private readonly ILogger<AddReportModel> _logger;
        private readonly ValorContext _context;
        [BindProperty]
        public Report Report {get; set;} = default!;
        public SelectList WellDropDown {get; set;} = default!;

        public AddReportModel(ValorContext context, ILogger<AddReportModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            WellDropDown = new SelectList(_context.Wells.ToList(), "WellID", "Well_Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
        
            _context.Reports.Add(Report);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
