using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Keyless]
    public partial class ViewRecebimento
    {
        public int IdCliente { get; set; }
        [Required]
        [StringLength(15)]
        public string CodEmprestimo { get; set; }
        [Column(TypeName = "date")]
        public DateTime Vencimento { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeCliente { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ValorParcela { get; set; }
        public bool Paga { get; set; }
        public long IdParcela { get; set; }
        [StringLength(250)]
        public string Observacao { get; set; }
        public bool Marcado { get; set; }
        [Column("codOrder")]
        [StringLength(5)]
        public string CodOrder { get; set; }
    }
}
