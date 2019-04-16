using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChefCore.Models
{
    public class IngredienteDaReceita
    {
        public int Id { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public Receita Receita { get; set; }
        public decimal Quantidade { get; set; }
        public int UnidadeDeMedida { get; set; }

        public enum eUnidadeDeMedida
        {
            Colher_de_Sopa = 0,
            Colher_de_Cha = 1,
            Xicara = 2,
            Ml = 3,
            Litros = 4,
            Gramas = 5,
            Kg = 6
        }
    }
}
