using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("FormaPagamento")]
    [Index(nameof(NomeFormaPagamento), Name = "UQ__FormaPag__DBD5431D4A63794C", IsUnique = true)]
    public partial class FormaPagamento
    {
        [Key]
        public int IdFormaPagamento { get; set; }
        [Required]
        [StringLength(50)]
        public string NomeFormaPagamento { get; set; }
    }
}
