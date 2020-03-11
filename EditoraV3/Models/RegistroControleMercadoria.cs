using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class RegistroControleMercadoria
    {
        [Key] public int ID_RegConMerc { get; set; }
        [JsonIgnore] public virtual List<Livro> ID_Livro { get; set; }
        [Required] [ForeignKey("ID_Livro")] public int Livro { get; set; }
        [Required] public int Quantidade { get; set; }
        [Required] public int Tipo { get; set; } // 1 = Venda (para o cliente) 2 = Reabastecimento (para a editora)
        [Required] public DateTime DataReg { get; set; }

    }
}