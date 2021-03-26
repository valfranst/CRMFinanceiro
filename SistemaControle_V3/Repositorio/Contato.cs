using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Contato")]
    public partial class Contato
    {
        [Key]
        public int IdContato { get; set; }
        public int IdCliente { get; set; }
        public bool Tipo { get; set; }
        [Required]
        [StringLength(20)]
        public string Telefone1 { get; set; }
        [StringLength(20)]
        public string Telefone2 { get; set; }
        [StringLength(20)]
        public string Telefone3 { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Facebook { get; set; }
        [StringLength(100)]
        public string Instagram { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Cliente.Contatos))]
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
