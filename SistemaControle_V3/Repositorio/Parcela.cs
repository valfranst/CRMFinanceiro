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
        public int IdParcela { get; set; }
        public int IdEmprestimo { get; set; }
        [Column(TypeName = "date")]
        public DateTime Vencimento { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorParcela { get; set; }
        [StringLength(50)]
        public string FormaPagamento { get; set; }
        public bool Paga { get; set; }
        [StringLength(250)]
        public string Observacao { get; set; }
        [StringLength(250)]
        public string ObservacaoEmprestimo { get; set; }

        [ForeignKey(nameof(IdEmprestimo))]
        [InverseProperty(nameof(Emprestimo.Parcelas))]
        public virtual Emprestimo IdEmprestimoNavigation { get; set; }
    }
}
