using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Valor.Models;

namespace ValorOil.Pages.Wells
{
    public class EditModel : PageModel
    {
        private readonly Valor.Models.ValorContext _context;

        public EditModel(Valor.Models.ValorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Well Well { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var well =  await _context.Wells.FirstOrDefaultAsync(m => m.WellID == id);
            if (well == null)
            {
                return NotFound();
            }
            Well = well;
           ViewData["OperatorID"] = new SelectList(_context.Operators, "OperatorID", "Email");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Well).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WellExists(Well.WellID))
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

        private bool WellExists(int id)
        {
            return _context.Wells.Any(e => e.WellID == id);
        }
    }
}
