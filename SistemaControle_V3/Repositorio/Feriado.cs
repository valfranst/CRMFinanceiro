using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Index(nameof(DataFeriado), Name = "UQ__Feriados__4A1277A8FED6CEA5", IsUnique = true)]
    public partial class Feriado
    {
        [Key]
        public int IdFeriado { get; set; }
        [Required]
        [StringLength(500)]
        public string NomeFeriado { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataFeriado { get; set; }
        public bool Anual { get; set; }
    }
}
