using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities;


[Table("Persona")]
public class Persona
{

    [Key]
    [Column("PersonaId")]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public string Dni { get; set; } = null!;
    public DateTime FechaCreacion { get; set; }


    public int DireccionId { get; set; }
    [ForeignKey("DireccionId")]
    public Direccion? Direccion { get; set; }

}
