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
    public class HistoryModel : PageModel
    {
        private readonly Help_Desk_new.Data.Help_Desk_newContext _context;

        public HistoryModel(Help_Desk_new.Data.Help_Desk_newContext context)
        {
            _context = context;
        }

        public IList<Ticket> Ticket { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ticket != null)
            {
                //Ticket = await _context.Ticket.ToListAsync();

                var tickets = from t in _context.Ticket select t;

                tickets = tickets.Where(a => a.isActive == false);

                Ticket = await tickets.ToListAsync();
            }
        }
    }
}
