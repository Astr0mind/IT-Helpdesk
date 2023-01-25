using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Help_Desk_new.Data;
using Help_Desk_new.Models;

namespace Help_Desk_new.Pages.Tickets
{
    public class DetailsModel : PageModel
    {
        private readonly Help_Desk_new.Data.Help_Desk_newContext _context;

        public DetailsModel(Help_Desk_new.Data.Help_Desk_newContext context)
        {
            _context = context;
        }

      public Ticket Ticket { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ticket == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }
            else 
            {
                Ticket = ticket;
            }
            return Page();
        }
    }
}
