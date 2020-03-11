using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class Autor
    {
        [Key] public int ID_Autor { get; set; }
        [Required] [StringLength(15)] public string CPF { get; set; }
        [Required] [StringLength(100)] public string Nome { get; set; }
        [JsonIgnore] public virtual List<Livro> livros { get; set; }
        [ForeignKey("livros")] public int Id_livros { get; set; }
    }
}