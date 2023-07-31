using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities;

[Table("Direccion")]
public class Direccion
{

    [Key]
    [Column("DireccionId")]
    public int Id { get; set; }

    public string Calle { get; set; } = null!;
    public string CodigoPostal { get; set; } = null!;
    public string Ciudad { get; set; } = null!;
    public string Pais { get; set; } = null!;
    public string? Comentarios { get; set; }
    public DateTime FechaCreacion { get; set; }

}
