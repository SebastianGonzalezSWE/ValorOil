using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Valor.Models;

namespace ValorOil.Pages.Wells
{
    public class IndexModel : PageModel
    {
        private readonly Valor.Models.ValorContext _context;

        public IndexModel(Valor.Models.ValorContext context)
        {
            _context = context;
        }

        public IList<Well> Well { get;set; } = default!;
        
          [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        public SelectList SortList {get; set;} = default!;
        public string CurrentFilter {get; set;} = string.Empty;
         public string NameSort { get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            //Well = await _context.Wells
            // .Include(w => w.Operator).ToListAsync();
              //CurrentFilter = SearchString;
                 if(_context.Wells != null){
                var WellSearch = _context.Wells.Select(p=> p);
                var query =_context.Wells.Select(w=> w);
                 List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "Well Ascending", Value = "first_asc" },
                    new SelectListItem { Text = "Well Name Descending", Value = "first_desc"}
                  };
                SortList =  new SelectList(sortItems, "Value", "Text", CurrentSort);
            
            switch (CurrentSort)
           {
             case "first_asc": 
            query = query.OrderBy(p => p.Well_Name);
                        break;
                    
                    case "first_desc":
                        query = query.OrderByDescending(p => p.Well_Name);
                        break;
           }
            switch (CurrentFilter)
            {
                case "WellName":
                WellSearch = WellSearch.OrderBy(s => s.Well_Name);
                break;
            }
           
           Well = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
           
            }
        }
    }
}
