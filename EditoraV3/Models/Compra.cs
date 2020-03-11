
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace EditoraV3.Models
{
    public class Compra
    {
        [Key] public int ID_Compra { get; set; }
        [Required] public string NomeCli { get; set; }
        [Required] public float Total_Pag { get; set; }
        [Required] public DateTime DataPag { get; set; }
    }
}