using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Emprestimo")]
    [Index(nameof(CodEmprestimo), Name = "UQ__Empresti__80EAF4F413169377", IsUnique = true)]
    public partial class Emprestimo
    {
        public Emprestimo()
        {
            Parcelas = new HashSet<Parcela>();
        }

        [Key]
        public long IdEmprestimo { get; set; }
        [Required]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        public int IdCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeAtendente { get; set; }
        public bool StatusEmprestimo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataAlteracao { get; set; }
        [Column(TypeName = "date")]
        public DateTime DataCadastro { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Valor { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Taxa { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorTotal { get; set; }
        public int QtdParcela { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorParcela { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PrimeiraParcela { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UltimaParcela { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorComissao { get; set; }
        public bool Refinanciado { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Complemento { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalRefinanciado { get; set; }
        [StringLength(50)]
        public string FormaPagamento { get; set; }
        [StringLength(15)]
        public string ReferenciaEmprestimo { get; set; }
        [StringLength(250)]
        public string Observacao { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Cliente.Emprestimos))]
        public virtual Cliente IdClienteNavigation { get; set; }
        [InverseProperty(nameof(Parcela.IdEmprestimoNavigation))]
        public virtual ICollection<Parcela> Parcelas { get; set; }
    }
}
