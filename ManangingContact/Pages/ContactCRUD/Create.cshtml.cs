using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManangingContact.Data;
using ManangingContact.Models;

namespace ManangingContact.Pages.ContactCRUD
{
    public class CreateModel : PageModel
    {
        private readonly ManangingContact.Data.ManangingContactContext _context;

        public CreateModel(ManangingContact.Data.ManangingContactContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contacts Contacts { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contacts.Add(Contacts);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
