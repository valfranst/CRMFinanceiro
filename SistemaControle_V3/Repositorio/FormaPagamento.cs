using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("FormaPagamento")]
    [Index(nameof(NomeFormaPagamento), Name = "UQ__FormaPag__1424905455D3D908", IsUnique = true)]
    public partial class FormaPagamento
    {
        [Key]
        [Column("idFormaPagamento")]
        public int IdFormaPagamento { get; set; }
        [Required]
        [Column("nomeFormaPagamento")]
        [StringLength(150)]
        public string NomeFormaPagamento { get; set; }
        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }
    }
}
