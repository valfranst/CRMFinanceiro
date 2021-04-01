using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Keyless]
    public partial class ViewCliente
    {
        public int IdCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeCliente { get; set; }
        [Required]
        [StringLength(15)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(20)]
        public string Residencial { get; set; }
        [StringLength(20)]
        public string WhatsApp { get; set; }
        [StringLength(20)]
        public string Celular { get; set; }
    }
}
