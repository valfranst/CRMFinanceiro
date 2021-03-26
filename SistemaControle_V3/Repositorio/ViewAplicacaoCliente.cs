using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Keyless]
    public partial class ViewAplicacaoCliente
    {
        public int IdEmprestimo { get; set; }
        [Required]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataCadastro { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeAtendente { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorComissao { get; set; }
        public int IdCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeCliente { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Taxa { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }
        public bool Marcado { get; set; }
        [Column("vencimento")]
        [StringLength(4000)]
        public string Vencimento { get; set; }
        [Column("codOrder")]
        [StringLength(5)]
        public string CodOrder { get; set; }
    }
}
