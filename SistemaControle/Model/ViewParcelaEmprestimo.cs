using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewParcelaEmprestimo
    {
        [Column("idParcela")]
        public int IdParcela { get; set; }
        [Column("idEmprestimo")]
        public int IdEmprestimo { get; set; }
        [Column("vencimento", TypeName = "date")]
        public DateTime Vencimento { get; set; }
        [Column("valorParcela", TypeName = "decimal(10, 3)")]
        public decimal ValorParcela { get; set; }
        [Column("paga")]
        public bool Paga { get; set; }
        [Column("formaPagamento")]
        [StringLength(50)]
        public string FormaPagamento { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("observacaoEmprestimo")]
        public string ObservacaoEmprestimo { get; set; }
    }
}
