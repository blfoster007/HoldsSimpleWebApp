using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoldsSimpleWebApp.Data;
using HoldsSimpleWebApp.Models;

namespace HoldsSimpleWebApp.Pages.OrderHolds
{
    public class EditModel : PageModel
    {
        private readonly HoldsSimpleWebApp.Data.HoldsSimpleWebAppContext _context;

        public EditModel(HoldsSimpleWebApp.Data.HoldsSimpleWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderHold OrderHold { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderHold = await _context.OrderHold.FirstOrDefaultAsync(m => m.OrderHoldID == id);

            if (OrderHold == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OrderHold).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderHoldExists(OrderHold.OrderHoldID))
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

        private bool OrderHoldExists(int id)
        {
            return _context.OrderHold.Any(e => e.OrderHoldID == id);
        }
    }
}
