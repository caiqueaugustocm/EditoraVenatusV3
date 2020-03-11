﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditoraV3.Models
{
    public class RedeSocial
    {
        [Key] public int ID_RedeSocial { get; set; }
        public string Email { get; set; } = null;
        public string Instagram { get; set; } = null;
        public string Twitter { get; set; } = null;
        public string Facebook { get; set; } = null;
        [JsonIgnore] public virtual List<Autor> id_autor { get; set; }
        [JsonIgnore] public virtual List<Cliente> id_cliente { get; set; }
        [ForeignKey("id_autor")] public int Id_aut { get; set; }
        [ForeignKey("id_cliente")] public int Id_cli { get; set; }
    }
}