using ManangingContact.Data;
using ManangingContact.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManangingContact.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private ManangingContactContext _Context;

        public IList<Contacts> Contacts;

        public IndexModel(ILogger<IndexModel> logger, ManangingContactContext Context)
        {
            _logger = logger;
            _Context = Context;
        }

        public async Task OnGetAsync()
        {
            Contacts = await _Context.Contacts.ToListAsync<Contacts>();
        }
    }
}
