using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegeBio.Data;
using VegeBio.Models;

namespace VegeBio.Models
{
    public static class DbInitialize
    {
        public static void Initialize(VegeBioContext context)
        {
            context.Database.EnsureCreated();
            if (context.ListaProdutos.Any())
            {
                return;
            }

            var products = new Produto[]
            {

            };

        }
    }
}
