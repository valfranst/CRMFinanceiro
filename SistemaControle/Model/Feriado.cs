using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Index(nameof(DataFeriado), Name = "UQ__Feriados__6CA2A8BD86841D19", IsUnique = true)]
    public partial class Feriado
    {
        [Key]
        [Column("idFeriado")]
        public int IdFeriado { get; set; }
        [Required]
        [Column("nomeFeriado")]
        [StringLength(500)]
        public string NomeFeriado { get; set; }
        [Column("dataFeriado", TypeName = "date")]
        public DateTime DataFeriado { get; set; }
        [Column("anual")]
        public bool Anual { get; set; }
        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }
    }
}
