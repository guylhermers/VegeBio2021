using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace VegeBio.Models
{
    public class Produto
    {
        public int id;

        [Display(Name = "Nome")]
        public string nome;

        [Display(Name = "Estação")]
        public string epoca;

        [Display(Name = "Preço")]
        public float preco;

        [Display(Name = "Descrição")]
        public float descricao;

        public string tipo;

        public string imageurl;

    }
}
