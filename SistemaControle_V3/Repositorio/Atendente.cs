using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Atendente")]
    [Index(nameof(NomeAtendente), Name = "UQ__Atendent__E824228A36F07CED", IsUnique = true)]
    public partial class Atendente
    {
        public Atendente()
        {
            DespesaFuncionarios = new HashSet<DespesaFuncionario>();
        }

        [Key]
        [Column("idAtendente")]
        public int IdAtendente { get; set; }
        [Required]
        [Column("nomeAtendente")]
        [StringLength(150)]
        public string NomeAtendente { get; set; }
        [Column("descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [InverseProperty(nameof(DespesaFuncionario.IdAtendenteNavigation))]
        public virtual ICollection<DespesaFuncionario> DespesaFuncionarios { get; set; }
    }
}
