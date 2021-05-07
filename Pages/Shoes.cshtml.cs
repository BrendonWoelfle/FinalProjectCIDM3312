using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FinalProjectCIDM3312.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProjectCIDM3312.Pages
{
    public class ShoesModel : PageModel
    {
        private readonly ShoeDbContext _context;
        public List<Shoe> Shoes {get; set;}

        [BindProperty(SupportsGet = true)]

        public int PageNum {get; set;} = 1;
        [BindProperty(SupportsGet = true)]
        public int PageSize {get; set;} = 10;
        
        [BindProperty]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public double Size {get; set;}
        
        [BindProperty]
        public string Brand {get; set;}
        
        [BindProperty]
        public string Color {get; set;}
        public string CurrentSort {get; set;}

        public ShoesModel(FinalProjectCIDM3312.Models.ShoeDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var query = _context.Shoe.Select(s => s);

            switch (CurrentSort)
            {
                case "Size_asc":
                    query = query.OrderBy(s => s.Size);
                    break;
                case "Size_desc":
                    query = query.OrderByDescending(s => s.Size);
                    break;
            }
            Shoes = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
        

    }
}
