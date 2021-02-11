using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewDespesaFuncionario
    {
        [Column("idDespesaFuncionario")]
        public int IdDespesaFuncionario { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime? DataCadastro { get; set; }
        [Required]
        [Column("nomeAtendente")]
        [StringLength(150)]
        public string NomeAtendente { get; set; }
        [Required]
        [Column("nomeDespesa")]
        [StringLength(150)]
        public string NomeDespesa { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal? Valor { get; set; }
    }
}
