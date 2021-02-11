using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewEmprestimoView
    {
        [Column("codEmprestimo")]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime? DataCadastro { get; set; }
        [Required]
        [Column("nomeAtendente")]
        [StringLength(60)]
        public string NomeAtendente { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal Valor { get; set; }
        [Column("taxa", TypeName = "decimal(10, 3)")]
        public decimal? Taxa { get; set; }
        [Column("fator", TypeName = "decimal(10, 7)")]
        public decimal? Fator { get; set; }
        [Column("banco")]
        [StringLength(50)]
        public string Banco { get; set; }
        [Column("formaPagamento")]
        [StringLength(50)]
        public string FormaPagamento { get; set; }
        [Column("valorTotal", TypeName = "decimal(10, 3)")]
        public decimal ValorTotal { get; set; }
        [Column("refinanciado")]
        public bool? Refinanciado { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("vencimento", TypeName = "date")]
        public DateTime Vencimento { get; set; }
        [Column("valorParcela", TypeName = "decimal(10, 3)")]
        public decimal ValorParcela { get; set; }
        [Column("paga")]
        public bool Paga { get; set; }
        [Column("idEmprestimo")]
        public int IdEmprestimo { get; set; }
        [Column("idParcela")]
        public int IdParcela { get; set; }
        [Column("idCliente")]
        public int IdCliente { get; set; }
    }
}
