using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewRecebimento
    {
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("codEmprestimo")]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column("vencimento", TypeName = "date")]
        public DateTime Vencimento { get; set; }
        [Required]
        [Column("nomeCliente")]
        [StringLength(150)]
        public string NomeCliente { get; set; }
        [Column("valorParcela", TypeName = "decimal(10, 3)")]
        public decimal ValorParcela { get; set; }
        [Column("paga")]
        public bool Paga { get; set; }
        [Column("idParcela")]
        public int IdParcela { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("marcado")]
        public bool Marcado { get; set; }
        [Column("codOrder")]
        [StringLength(5)]
        public string CodOrder { get; set; }
    }
}
