using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaControle_V3
{
    [Table("DespesaFuncionario")]
    public partial class DespesaFuncionario
    {
        [Key]
        [Column("idDespesaFuncionario")]
        public int IdDespesaFuncionario { get; set; }
        [Column("idDespesa")]
        public int IdDespesa { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime? DataCadastro { get; set; }
        [Column("idAtendente")]
        public int IdAtendente { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal? Valor { get; set; }

        [ForeignKey(nameof(IdAtendente))]
        [InverseProperty(nameof(Atendente.DespesaFuncionarios))]
        public virtual Atendente IdAtendenteNavigation { get; set; }
        [ForeignKey(nameof(IdDespesa))]
        [InverseProperty(nameof(Despesa.DespesaFuncionarios))]
        public virtual Despesa IdDespesaNavigation { get; set; }
    }
}
