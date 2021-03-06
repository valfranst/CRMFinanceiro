﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SistemaControle.Model
{
    [Table("Cliente")]
    [Index(nameof(NomeCliente), Name = "UQ__Cliente__8182EFAE742F3385", IsUnique = true)]
    [Index(nameof(Cpf), Name = "UQ__Cliente__D836E71FA9783B40", IsUnique = true)]
    public partial class Cliente
    {
        public Cliente()
        {
            Emprestimos = new HashSet<Emprestimo>();
        }

        [Key]
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nomeCliente")]
        [StringLength(150)]
        public string NomeCliente { get; set; }
        [Column("dataNascimento", TypeName = "date")]
        public DateTime? DataNascimento { get; set; }
        [Required]
        [Column("cpf")]
        [StringLength(50)]
        public string Cpf { get; set; }
        [Column("rg")]
        [StringLength(50)]
        public string Rg { get; set; }
        [Column("telResidencial")]
        [StringLength(50)]
        public string TelResidencial { get; set; }
        [Column("telCelularzap")]
        [StringLength(50)]
        public string TelCelularzap { get; set; }
        [Column("telCelular2")]
        [StringLength(50)]
        public string TelCelular2 { get; set; }
        [Column("enderecoResidencial")]
        [StringLength(500)]
        public string EnderecoResidencial { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("facebook")]
        [StringLength(100)]
        public string Facebook { get; set; }
        [Column("instagran")]
        [StringLength(100)]
        public string Instagran { get; set; }
        [Column("empresa")]
        [StringLength(100)]
        public string Empresa { get; set; }
        [Column("cargo")]
        [StringLength(100)]
        public string Cargo { get; set; }
        [Column("salarioLiquido", TypeName = "decimal(10, 3)")]
        public decimal? SalarioLiquido { get; set; }
        [Column("dataEmpresa", TypeName = "date")]
        public DateTime? DataEmpresa { get; set; }
        [Column("telComercial1")]
        [StringLength(50)]
        public string TelComercial1 { get; set; }
        [Column("telComercial2")]
        [StringLength(50)]
        public string TelComercial2 { get; set; }
        [Column("telComercial3")]
        [StringLength(50)]
        public string TelComercial3 { get; set; }
        [Column("enderecoEmpresarial")]
        [StringLength(500)]
        public string EnderecoEmpresarial { get; set; }
        [Column("referencia1")]
        [StringLength(500)]
        public string Referencia1 { get; set; }
        [Column("referencia2")]
        [StringLength(500)]
        public string Referencia2 { get; set; }
        [Column("referencia3")]
        [StringLength(500)]
        public string Referencia3 { get; set; }
        [Column("observacao")]
        public string Observacao { get; set; }
        [Column("statusCadastro")]
        public bool StatusCadastro { get; set; }
        [Column("indicacao")]
        [StringLength(500)]
        public string Indicacao { get; set; }
        [Column("dataCadastro", TypeName = "datetime")]
        public DateTime DataCadastro { get; set; }
        [Required]
        [Column("nomeClienteNormalizado")]
        [StringLength(150)]
        public string NomeClienteNormalizado { get; set; }
        [Column("pesquisa")]
        [StringLength(354)]
        public string Pesquisa { get; set; }
        [Column("referencia")]
        [StringLength(500)]
        public string Referencia { get; set; }
        [Column("endResidencial")]
        [StringLength(500)]
        public string EndResidencial { get; set; }
        [Column("endEmpresarial")]
        [StringLength(500)]
        public string EndEmpresarial { get; set; }
        [Column("marcado")]
        public bool Marcado { get; set; }

        [InverseProperty(nameof(Emprestimo.IdClienteNavigation))]
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
