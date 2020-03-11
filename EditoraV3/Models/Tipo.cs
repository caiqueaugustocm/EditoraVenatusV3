using System.ComponentModel.DataAnnotations;

namespace EditoraV3.Models
{
    public class Tipo
    {
        [Key] public int ID_Tipo { get; set; }
        [Required] [StringLength(50)] public string Descricao { get; set; }
    }
}