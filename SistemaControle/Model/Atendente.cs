using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Table("Atendente")]
    [Index(nameof(NomeAtendente), Name = "UQ__Atendent__E824228A36F07CED", IsUnique = true)]
    public partial class Atendente
    {
        [Key]
        [Column("idAtendente")]
        public int IdAtendente { get; set; }
        [Required]
        [Column("nomeAtendente")]
        [StringLength(150)]
        public string NomeAtendente { get; set; }
        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }
    }
}
