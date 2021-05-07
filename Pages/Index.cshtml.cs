using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using FinalProjectCIDM3312.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace FinalProjectCIDM3312.Models
{
    public class IndexModel : PageModel
    {
        private readonly FinalProjectCIDM3312.Models.ShirtDbContext _context;


        public IndexModel(FinalProjectCIDM3312.Models.ShirtDbContext context)
        {
            _context = context;
        }

        public IList<Shirt> Shirt {get; set;}
        
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        public async Task OnGetAsync()
        {
            Shirt = await _context.Shirt.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
