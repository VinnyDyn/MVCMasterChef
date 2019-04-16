using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChefCore.Models
{
    public class Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<IngredienteDaReceita> Ingredientes { get; set; }
        public string ModoDePreparo { get; set; }
        public decimal TempoDePreparo { get; set; }
        public byte[] Foto { get; set; }
    }
}
