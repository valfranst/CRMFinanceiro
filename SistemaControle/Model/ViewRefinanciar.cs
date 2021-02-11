using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewRefinanciar
    {
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("idEmprestimo")]
        public int IdEmprestimo { get; set; }
        [Column("codEmprestimo")]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column("ultimaParcela", TypeName = "date")]
        public DateTime? UltimaParcela { get; set; }
        [Required]
        [Column("nomeCliente")]
        [StringLength(150)]
        public string NomeCliente { get; set; }
        [Column("telCelularzap")]
        [StringLength(50)]
        public string TelCelularzap { get; set; }
        [Column("valorParcela", TypeName = "decimal(10, 3)")]
        public decimal ValorParcela { get; set; }
        [Column("complemento", TypeName = "decimal(10, 3)")]
        public decimal Complemento { get; set; }
        [Column("totalRefinanciado", TypeName = "decimal(10, 3)")]
        public decimal TotalRefinanciado { get; set; }
        [Column("refinanciado")]
        public bool Refinanciado { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("referenciaEmprestimo")]
        [StringLength(15)]
        public string ReferenciaEmprestimo { get; set; }
        [Column("marcado")]
        public bool Marcado { get; set; }
    }
}
