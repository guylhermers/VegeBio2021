using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace VegeBio.Models
{
    public class Produto
    {
        private int id;

        private string epoca;

        private float preco;

        private string tipo;

        private string imageurl;

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

        public void converterImagem()
        {
        }
    }
}
