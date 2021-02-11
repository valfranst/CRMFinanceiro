using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewAplicacaoCliente
    {
        [Column("idEmprestimo")]
        public int IdEmprestimo { get; set; }
        [Column("codEmprestimo")]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime? DataCadastro { get; set; }
        [Required]
        [Column("nomeAtendente")]
        [StringLength(60)]
        public string NomeAtendente { get; set; }
        [Column("valorComissao", TypeName = "decimal(10, 3)")]
        public decimal ValorComissao { get; set; }
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nomeCliente")]
        [StringLength(150)]
        public string NomeCliente { get; set; }
        [Column("taxa", TypeName = "decimal(10, 3)")]
        public decimal? Taxa { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal Valor { get; set; }
        [Column("marcado")]
        public bool Marcado { get; set; }
        [Column("vencimento")]
        [StringLength(4000)]
        public string Vencimento { get; set; }
        [Column("codOrder")]
        [StringLength(5)]
        public string CodOrder { get; set; }
    }
}
