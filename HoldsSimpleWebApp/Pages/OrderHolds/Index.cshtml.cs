using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HoldsSimpleWebApp.Data;
using HoldsSimpleWebApp.Models;

namespace HoldsSimpleWebApp.Pages.OrderHolds
{
    public class IndexModel : PageModel
    {
        private readonly HoldsSimpleWebApp.Data.HoldsSimpleWebAppContext _context;

        public IndexModel(HoldsSimpleWebApp.Data.HoldsSimpleWebAppContext context)
        {
            _context = context;
        }

        public IList<OrderHold> OrderHold { get;set; }

        public async Task OnGetAsync()
        {
            OrderHold = await _context.OrderHold.ToListAsync();
        }
    }
}
