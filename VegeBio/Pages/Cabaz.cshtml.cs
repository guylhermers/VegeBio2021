using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VegeBio.Data;
using VegeBio.Models;


namespace VegeBio.Pages
{
    public class CabazModel : PageModel
    {
      
            private readonly VegeBioContext _context;
            public CabazModel(VegeBioContext context)
            {
                _context = context;
            }
            [Required(ErrorMessage = "Email Obrigat�rio")]
            [BindProperty]
            public string CustomerEmail { get; set; }
            [Required(ErrorMessage = "Morada Obrigat�ria")]
            [BindProperty]
            public string ShippingAddress { get; set; }
            [Required(ErrorMessage = "Quantidade Obrigat�ria")]
            [BindProperty]
            public int OrderQt { get; set; } = 1;
            public Produto Produto { get; set; }
        }
}
