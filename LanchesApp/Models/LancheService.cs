using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanchesApp.Models;

namespace LanchesApp.Models
{
    public class LancheService
    {
        public static List<Lanche> ObterLanches()
        {
            return new List<Lanche>
        {
            new Lanche { Nome = "Hambúrguer", Descricao = "Delicioso hambúrguer com carne queijo e salada.", Imagem = "hamburguer.jpg"},
            new Lanche { Nome = "Pizza", Descricao = "Pizza de pepperoni com queijo derretido.", Imagem = "pizza.jpg"},
            new Lanche { Nome = "Cachorro-quente", Descricao = "Cachorro-quente com salsicha, molho e mostarda.", Imagem = "cachorroquente.jpg"}
        };
        }
    }
}
