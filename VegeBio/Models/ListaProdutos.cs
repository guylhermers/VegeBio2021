using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBio.Models
{
    public class ListaProdutos : Produto
    {
        private List<Produto> listaProduto;
        private string epoca;
        private int id;

        public ListaProdutos(string epoca, int id)
        {
            this.epoca = epoca;
            this.id = id;
        }

        public void adicionarProduto(Produto produto)
        {
            ListaProduto.Add(produto);
        }
        public void

        public List<Produto> ListaProduto { get => listaProduto; set => listaProduto = value; }
        public string Epoca { get => epoca; set => epoca = value; }
        public int Id { get => id; set => id = value; }
    }
}
