using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle_V3
{
    [Table("Cliente")]
    [Index(nameof(NomeCliente), Name = "UQ__Cliente__7507A385824CEF24", IsUnique = true)]
    [Index(nameof(Cpf), Name = "UQ__Cliente__C1FF930986E40394", IsUnique = true)]
    public partial class Cliente
    {
        public Cliente()
        {
            Contatos = new HashSet<Contato>();
            Emprestimos = new HashSet<Emprestimo>();
            Enderecos = new HashSet<Endereco>();
        }

        [Key]
        public int IdCliente { get; set; }
        [Column("dataCadastro", TypeName = "datetime")]
        public DateTime DataCadastro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataAlteracao { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string NomeClienteNormalizado { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Nascimento { get; set; }
        [Required]
        [StringLength(15)]
        public string Cpf { get; set; }
        [StringLength(20)]
        public string Rg { get; set; }
        [Required]
        [StringLength(500)]
        public string Pesquisa { get; set; }
        [StringLength(100)]
        public string Empresa { get; set; }
        [StringLength(100)]
        public string Cargo { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Salario { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataEmpresa { get; set; }
        [StringLength(50)]
        public string Referencia1 { get; set; }
        [StringLength(50)]
        public string Referencia2 { get; set; }
        [StringLength(50)]
        public string Referencia3 { get; set; }
        [StringLength(20)]
        public string TelefoneR1 { get; set; }
        [StringLength(20)]
        public string TelefoneR2 { get; set; }
        [StringLength(20)]
        public string TelefoneR3 { get; set; }
        [StringLength(150)]
        public string Indicacao { get; set; }
        [StringLength(250)]
        public string Observacao { get; set; }
        public bool Marcado { get; set; }

        [InverseProperty(nameof(Contato.IdClienteNavigation))]
        public virtual ICollection<Contato> Contatos { get; set; }
        [InverseProperty(nameof(Emprestimo.IdClienteNavigation))]
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
        [InverseProperty(nameof(Endereco.IdClienteNavigation))]
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
