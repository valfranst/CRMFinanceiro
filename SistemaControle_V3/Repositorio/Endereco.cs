using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Endereco")]
    public partial class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public int IdCliente { get; set; }
        public bool Tipo { get; set; }
        [Required]
        [StringLength(10)]
        public string Cep { get; set; }
        [Required]
        [StringLength(100)]
        public string Lagradouro { get; set; }
        public int Numero { get; set; }
        [StringLength(100)]
        public string Complemento { get; set; }
        [StringLength(100)]
        public string Conjunto { get; set; }
        [Required]
        [StringLength(100)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(100)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(3)]
        public string Estado { get; set; }
        [Required]
        [StringLength(100)]
        public string Pais { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Cliente.Enderecos))]
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
