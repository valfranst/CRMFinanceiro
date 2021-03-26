using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Keyless]
    public partial class ViewRefinanciar
    {
        public int IdCliente { get; set; }
        public int IdEmprestimo { get; set; }
        public int IdContato { get; set; }
        [Required]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UltimaParcela { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeCliente { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefone1 { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorParcela { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Complemento { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalRefinanciado { get; set; }
        public bool Refinanciado { get; set; }
        [StringLength(250)]
        public string Observacao { get; set; }
        [StringLength(15)]
        public string ReferenciaEmprestimo { get; set; }
        public bool Marcado { get; set; }
    }
}
