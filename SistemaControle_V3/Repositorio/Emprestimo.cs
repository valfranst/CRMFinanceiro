using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Emprestimo")]
    [Index(nameof(CodEmprestimo), Name = "UQ__Empresti__2FD763A2A1C8B48D", IsUnique = true)]
    public partial class Emprestimo
    {
        public Emprestimo()
        {
            Parcelas = new HashSet<Parcela>();
        }

        [Key]
        [Column("idEmprestimo")]
        public int IdEmprestimo { get; set; }
        [Column("codEmprestimo")]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nomeAtendente")]
        [StringLength(60)]
        public string NomeAtendente { get; set; }
        [Column("statusEmprestimo")]
        public bool StatusEmprestimo { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime? DataCadastro { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal Valor { get; set; }
        [Column("taxa", TypeName = "decimal(10, 3)")]
        public decimal? Taxa { get; set; }
        [Column("fator", TypeName = "decimal(10, 7)")]
        public decimal? Fator { get; set; }
        [Column("valorTotal", TypeName = "decimal(10, 3)")]
        public decimal ValorTotal { get; set; }
        [Column("qtdParcela")]
        public int QtdParcela { get; set; }
        [Column("valorParcela", TypeName = "decimal(10, 3)")]
        public decimal ValorParcela { get; set; }
        [Column("primeiraParcela", TypeName = "date")]
        public DateTime? PrimeiraParcela { get; set; }
        [Column("ultimaParcela", TypeName = "date")]
        public DateTime? UltimaParcela { get; set; }
        [Column("percentComissao")]
        public int? PercentComissao { get; set; }
        [Column("valorComissao", TypeName = "decimal(10, 3)")]
        public decimal ValorComissao { get; set; }
        [Column("refinanciado")]
        public bool Refinanciado { get; set; }
        [Column("complemento", TypeName = "decimal(10, 3)")]
        public decimal Complemento { get; set; }
        [Column("banco")]
        [StringLength(50)]
        public string Banco { get; set; }
        [Column("formaPagamento")]
        [StringLength(50)]
        public string FormaPagamento { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("dataCadastroAlteracao", TypeName = "datetime")]
        public DateTime DataCadastroAlteracao { get; set; }
        [Column("totalRefinanciado", TypeName = "decimal(10, 3)")]
        public decimal TotalRefinanciado { get; set; }
        [Column("referenciaEmprestimo")]
        [StringLength(15)]
        public string ReferenciaEmprestimo { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Cliente.Emprestimos))]
        public virtual Cliente IdClienteNavigation { get; set; }
        [InverseProperty(nameof(Parcela.IdEmprestimoNavigation))]
        public virtual ICollection<Parcela> Parcelas { get; set; }
    }
}
