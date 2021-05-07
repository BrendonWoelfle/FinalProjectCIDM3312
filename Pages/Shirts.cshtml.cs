using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FinalProjectCIDM3312.Models;


namespace FinalProjectCIDM3312.Pages
{
    public class ShirtsModel : PageModel
    {
        private readonly ShirtDbContext _context;
        private readonly ILogger<ShirtsModel> _logger;
        public List<Shirt> Shirts {get; set;}
        [BindProperty]
        public string TSize {get; set;}
        public string TBrand {get; set;}
        public string TColor {get; set;}
        public string TDesign  {get; set;}

        public ShirtsModel(ShirtDbContext context, ILogger<ShirtsModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Shirts = _context.Shirt.ToList();
        }


    }
}
