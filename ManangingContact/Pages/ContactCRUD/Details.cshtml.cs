using ManangingContact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ManangingContact.Pages.ContactCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly ManangingContact.Data.ManangingContactContext _context;

        public DetailsModel(ManangingContact.Data.ManangingContactContext context)
        {
            _context = context;
        }

        public Contacts Contacts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contacts = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (Contacts == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
