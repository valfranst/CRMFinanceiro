using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Parcela")]
    public partial class Parcela
    {
        [Key]
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
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("formaPagamento")]
        [StringLength(50)]
        public string FormaPagamento { get; set; }
        [Column("observacaoEmprestimo")]
        [StringLength(500)]
        public string ObservacaoEmprestimo { get; set; }

        [ForeignKey(nameof(IdEmprestimo))]
        [InverseProperty(nameof(Emprestimo.Parcelas))]
        public virtual Emprestimo IdEmprestimoNavigation { get; set; }
    }
}
