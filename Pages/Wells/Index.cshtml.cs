using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Valor.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization.Infrastructure;

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
        public string Sort {get; set;} = string.Empty;
        public SelectList SortList {get; set;} = default!;
        public string CFilter {get; set;} = string.Empty;

        public async Task OnGetAsync(string searchString)
        {
                 if(_context.Wells != null){
               // var WellOrder= _context.Wells.Select(w=>w);
                var Order =_context.Wells.Include(w=>w.Operator).Select(w=> w);
                 List<SelectListItem> sortItems = new List<SelectListItem>
                  {
                    new SelectListItem { Text = "Ascending", Value = "ASC" },
                    new SelectListItem { Text = "Descending", Value = "DESC"}
                  };
              if(!string.IsNullOrEmpty(searchString)){
                  Order = Order.Where(w=> w.Well_Name.Contains(searchString));
              }

            SortList =  new SelectList(sortItems, "Value", "Text", Sort);
            CFilter = searchString;

            switch (Sort)
           {
             case "ASC": 
            Order = Order.OrderBy(p => p.Well_Name);
                        break;
                    
              case "DESC":
                        Order = Order.OrderByDescending(p => p.Well_Name);
                        break;
              case "Well_Name":
              Order = Order.OrderBy(w=> w.Well_Name);
            break;
           }
           
           
           Well = await Order.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
  
            }
        }
    }
    

}
