using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class Estoque
    {
        [Key] public int ID_Estoque { get; set; }
        [Required] public int Quantidade { get; set; }
        [JsonIgnore] public virtual List<Livro> ID_Livro { get; set; } //FK
        [Required] [ForeignKey("ID_Livro")] public int Livro { get; set; }
    }
}