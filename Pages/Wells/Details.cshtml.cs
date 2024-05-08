using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Valor.Models;

namespace ValorOil.Pages.Wells
{
    public class DetailsModel : PageModel
    {
        private readonly Valor.Models.ValorContext _context;

        public DetailsModel(Valor.Models.ValorContext context)
        {
            _context = context;
        }

        public Well Well { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var well = await _context.Wells.FirstOrDefaultAsync(m => m.WellID == id);
            if (well == null)
            {
                return NotFound();
            }
            else
            {
                Well = well;
            }
            return Page();
        }
    }
}
