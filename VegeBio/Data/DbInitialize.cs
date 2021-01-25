using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegeBio.Data;
using VegeBio.Models;

namespace VegeBio.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VegeBioContext context)
        {
            context.Database.EnsureCreated();
            if (context.ListaProdutos.Any())
            {
                return;
            }

            var produtos = new Produto[]
            {
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.jpg"}
            };

            foreach (Produto produto in produtos)
            {
                context.ListaProdutos.Add(produto);
            }
            context.SaveChanges();
        } 
    }
}

