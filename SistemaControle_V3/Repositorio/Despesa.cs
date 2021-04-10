using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Despesa")]
    [Index(nameof(NomeDespesa), Name = "UQ__Despesa__3A78E8B5CC6C9206", IsUnique = true)]
    public partial class Despesa
    {
        public Despesa()
        {
            DespesaFuncionarios = new HashSet<DespesaFuncionario>();
        }

        [Key]
        [Column("idDespesa")]
        public int IdDespesa { get; set; }
        [Required]
        [Column("nomeDespesa")]
        [StringLength(150)]
        public string NomeDespesa { get; set; }
        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [InverseProperty(nameof(DespesaFuncionario.IdDespesaNavigation))]
        public virtual ICollection<DespesaFuncionario> DespesaFuncionarios { get; set; }
    }
}
