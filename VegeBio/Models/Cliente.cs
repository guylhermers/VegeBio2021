using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBio.Models
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string morada;
        private int nif;



        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Morada { get => morada; set => morada = value; }
        public int Nif { get => nif; set => nif = value; }
    }
}
