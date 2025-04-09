using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesApp.Models
{
    public class BebidaService
    {
        public static List<Bebida> ObterBebida()
        {
            return new List<Bebida>
        {
                new Bebida { Nome = "Suco de Laranja", Descricao = "Suco de Laranja natural 400ml", Imagem = "suco.jpg"},
                new Bebida { Nome = "Cerveja", Descricao = "Cerveja Skol 350ml", Imagem = "skol.jpg"},
                new Bebida { Nome = "Coca", Descricao = "Refrigerante de Cola lata 350ml", Imagem = "coca.jpg"}
         };
        }
    }
}
