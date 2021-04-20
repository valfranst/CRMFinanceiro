using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Keyless]
    public partial class ViewListCliente
    {
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nomeCliente")]
        [StringLength(150)]
        public string NomeCliente { get; set; }
        [Required]
        [Column("cpf")]
        [StringLength(50)]
        public string Cpf { get; set; }
        [Column("pesquisa")]
        [StringLength(354)]
        public string Pesquisa { get; set; }
        [Column("telResidencial")]
        [StringLength(50)]
        public string TelResidencial { get; set; }
        [Column("telCelularzap")]
        [StringLength(50)]
        public string TelCelularzap { get; set; }
        [Column("telCelular2")]
        [StringLength(50)]
        public string TelCelular2 { get; set; }
        [Column("ultimaParcela", TypeName = "date")]
        public DateTime? UltimaParcela { get; set; }
    }
}
