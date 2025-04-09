using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesApp.Models
{
    public class DoceService
    {
        public static List<Doce> ObterDoces()
        {
            return new List<Doce>
        {
            new Doce { Nome = "Sonho", Descricao = "Sonho recheado com doce de leite", Imagem = "sonho.jpg"},
            new Doce { Nome = "Bomba", Descricao = "Deliciosa bomba de chocolate", Imagem = "bomba.jpg"},
            new Doce { Nome = "Pudim", Descricao = "Pudim de Leite com calda de caramelo", Imagem = "pudim.jpg"}
            };
        }
    }
}
