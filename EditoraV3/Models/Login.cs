﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class Login
    {
        [Key] public int ID_Login { get; set; }
        [JsonIgnore] public virtual List<Autor> id_autor { get; set; }

        [JsonIgnore] public virtual List<Cliente> id_cliente { get; set; }
        [ForeignKey("id_autor")] public int autor { get; set; }
        [ForeignKey("id_cliente")] public int cliente { get; set; }
        [Required] [StringLength(20)] public string Usuario { get; set; }
        [Required] [StringLength(24)] public string Senha { get; set; }
    }
}