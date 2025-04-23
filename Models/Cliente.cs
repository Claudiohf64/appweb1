using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace appweb1.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente{ get; set;}
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
    }
}