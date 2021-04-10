using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaControle_V3
{
    [Table("DespesaMensal")]
    public partial class DespesaMensal
    {
        [Key]
        [Column("idDespesaMensal")]
        [StringLength(6)]
        public string IdDespesaMensal { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal Valor { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime DataCadastro { get; set; }
    }
}
