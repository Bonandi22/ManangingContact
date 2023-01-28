using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManangingContact.Data;
using ManangingContact.Models;

namespace ManangingContact.Pages.ContactCRUD
{
    public class IndexModel : PageModel
    {
        private readonly ManangingContact.Data.ManangingContactContext _context;

        public IndexModel(ManangingContact.Data.ManangingContactContext context)
        {
            _context = context;
        }

        public IList<Contacts> Contacts { get;set; }

        public async Task OnGetAsync()
        {
            Contacts = await _context.Contacts.ToListAsync();
        }
    }
}
