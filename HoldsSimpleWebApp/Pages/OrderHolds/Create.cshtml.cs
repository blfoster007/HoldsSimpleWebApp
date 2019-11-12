using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HoldsSimpleWebApp.Data;
using HoldsSimpleWebApp.Models;

namespace HoldsSimpleWebApp.Pages.OrderHolds
{
    public class CreateModel : PageModel
    {
        private readonly HoldsSimpleWebApp.Data.HoldsSimpleWebAppContext _context;

        public CreateModel(HoldsSimpleWebApp.Data.HoldsSimpleWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OrderHold OrderHold { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderHold.Add(OrderHold);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
