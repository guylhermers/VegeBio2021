using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBio.Models
{
    public class Produto : ListaProdutos
    {
        private int id;

        private string epoca;

        private float preco;

        private string tipo;


        public int ID { get => id; set => id = value; }
        public string Epoca { get => epoca; set => epoca = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Produto(int id, string epoca, float preco, string tipo)
        {
            this.id = id;
            this.epoca = epoca;
            this.preco = preco;
            this.tipo = tipo;
        }

        public verificarEpoca()
        {

        }
    }
}
