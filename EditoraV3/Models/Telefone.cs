﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class Telefone
    {
        [Key] public int ID_Telefone { get; set; }
        [Required] [StringLength(15)] public string Tipo_Telefone { get; set; }
        [Required] [StringLength(20)] public string Numero { get; set; }
        [JsonIgnore] public virtual List<Autor> id_autor { get; set; }
        [JsonIgnore] public virtual List<Cliente> id_cliente { get; set; }
        [ForeignKey("id_autor")] public int Id_a { get; set; }
        [ForeignKey("id_cliente")] public int Id_c { get; set; }
    }
}