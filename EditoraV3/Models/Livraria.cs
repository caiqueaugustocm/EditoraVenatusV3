using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class Livraria
    {
        [Key] public int ID_Livraria { get; set; }
        [Required] [ForeignKey("Id_cliente")] public int Cliente { get; set; }
        [JsonIgnore] public virtual List<Cliente> Id_cliente { get; set; } // fk
        [Required] [StringLength(15)] public string CNPJ { get; set; }
        [Required] [StringLength(50)] public string Tipo_Consignacao { get; set; }
        [Required] [StringLength(50)] public string Nome { get; set; }
    }
}