using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VegeBio.Data;
using VegeBio.Models;

namespace VegeBio.Pages
{
    public class ProdutosModel : PageModel
    {
        private readonly VegeBioContext _context;

        public ProdutosModel(VegeBioContext context)
        {
            _context = context;
        }

        public IList<Produto> listaProduto { get; set; }
        public async Task OnGetAsync()
        {
            listaProduto = await _context.ListaProdutos.AsNoTracking().ToListAsync();
        }
    }
}
