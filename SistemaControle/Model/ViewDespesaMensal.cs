using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Keyless]
    public partial class ViewDespesaMensal
    {
        [Column("idDespesaMensal")]
        public int IdDespesaMensal { get; set; }
        [Column("dataCadastro", TypeName = "date")]
        public DateTime? DataCadastro { get; set; }
        [Column("valor", TypeName = "decimal(10, 3)")]
        public decimal? Valor { get; set; }
        [Required]
        [Column("nomeIdentificador")]
        [StringLength(150)]
        public string NomeIdentificador { get; set; }
        [Required]
        [Column("nomeDespesa")]
        [StringLength(150)]
        public string NomeDespesa { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
    }
}
