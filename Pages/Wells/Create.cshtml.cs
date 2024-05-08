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
    public class CreateModel : PageModel
    {
        private readonly Valor.Models.ValorContext _context;

        public CreateModel(Valor.Models.ValorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OperatorID"] = new SelectList(_context.Operators, "OperatorID", "Email");
            return Page();
        }

        [BindProperty]
        public Well Well { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Wells.Add(Well);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
