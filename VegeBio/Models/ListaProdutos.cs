using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBio.Models
{
    public class ListaProdutos : Produto
    {
        private List<Produto> listaProduto;
        private string epocaatual;

        public ListaProdutos(string epoca, int id)
        {
            this.epocaatual = epoca;
        }

        public bool adicionarProduto(Produto produto)
        {
            if (produto.Epoca == EpocaAtual)
            {
                ListaProduto.Add(produto);
                return true;
            }

            else return false;
            
        }
        public void removerProduto(Produto produto)
        {
            foreach (Produto p in ListaProduto)
            {
                if (p.ID == produto.ID)
                {
                    ListaProduto.Remove(p);
                }
            }
        }

        public string verificarEpoca(Produto p)
        {
            if (p.Epoca == this.EpocaAtual)
            {
                return ($"O produto encontra-se na época atual {p.Epoca}");
            }
            else return ($"O produto encontra-se na época {p.Epoca}");
        }

        public float verificarPreco (Produto p)
        {
            return p.Preco;
        }
        public List<Produto> ListaProduto { get => listaProduto; set => listaProduto = value; }
        public string EpocaAtual { get => epocaatual; set => epocaatual = value; }
    }
}
