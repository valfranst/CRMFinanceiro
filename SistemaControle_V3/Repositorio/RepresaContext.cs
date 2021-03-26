using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SistemaControle_V3
{
    public partial class RepresaContext : DbContext
    {
        private readonly string connectionString;
        public RepresaContext() : base()
        {
            MyConfig myConfig = MyConfig._getInstance();
            connectionString = myConfig.Conexao;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public RepresaContext(DbContextOptions<RepresaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Atendente> Atendentes { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<DespesaMensal> DespesaMensals { get; set; }
        public virtual DbSet<Emprestimo> Emprestimos { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Feriado> Feriados { get; set; }
        public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public virtual DbSet<Parcela> Parcelas { get; set; }
        public virtual DbSet<ViewAplicacaoCliente> ViewAplicacaoClientes { get; set; }
        public virtual DbSet<ViewRecebimento> ViewRecebimentos { get; set; }
        public virtual DbSet<ViewRefinanciar> ViewRefinanciars { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Atendente>(entity =>
            {
                entity.HasKey(e => e.IdAtendente)
                    .HasName("PK__Atendent__6AEB111E03A6ED14");

                entity.Property(e => e.NomeAtendente).IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__D594664262974D08");

                entity.Property(e => e.Cargo).IsUnicode(false);

                entity.Property(e => e.Cpf).IsUnicode(false);

                entity.Property(e => e.DataAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Empresa).IsUnicode(false);

                entity.Property(e => e.Indicacao).IsUnicode(false);

                entity.Property(e => e.NomeCliente).IsUnicode(false);

                entity.Property(e => e.NomeClienteNormalizado).IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.Property(e => e.Pesquisa).IsUnicode(false);

                entity.Property(e => e.Referencia1).IsUnicode(false);

                entity.Property(e => e.Referencia2).IsUnicode(false);

                entity.Property(e => e.Referencia3).IsUnicode(false);

                entity.Property(e => e.Rg).IsUnicode(false);

                entity.Property(e => e.TelefoneR1).IsUnicode(false);

                entity.Property(e => e.TelefoneR2).IsUnicode(false);

                entity.Property(e => e.TelefoneR3).IsUnicode(false);
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.IdContato)
                    .HasName("PK__Contato__2AC4F064056A4EEC");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Facebook).IsUnicode(false);

                entity.Property(e => e.Instagram).IsUnicode(false);

                entity.Property(e => e.Telefone1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Telefone2).IsUnicode(false);

                entity.Property(e => e.Telefone3).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Contatos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Contato_Cliente");
            });

            modelBuilder.Entity<DespesaMensal>(entity =>
            {
                entity.HasKey(e => e.IdDespesaMensal)
                    .HasName("PK__DespesaM__47E6CD73D0BC007C");

                entity.Property(e => e.IdDespesaMensal).IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Emprestimo>(entity =>
            {
                entity.HasKey(e => e.IdEmprestimo)
                    .HasName("PK__Empresti__2BEA0208AA6D29BF");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.DataAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormaPagamento).IsUnicode(false);

                entity.Property(e => e.NomeAtendente).IsUnicode(false);

                entity.Property(e => e.ReferenciaEmprestimo).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Emprestimos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Cliente_Emprestimo");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.IdEndereco)
                    .HasName("PK__Endereco__0B7C7F17114D5683");

                entity.Property(e => e.Bairro).IsUnicode(false);

                entity.Property(e => e.Cep).IsUnicode(false);

                entity.Property(e => e.Cidade).IsUnicode(false);

                entity.Property(e => e.Complemento).IsUnicode(false);

                entity.Property(e => e.Conjunto).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Lagradouro).IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Brasil')");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Enderecos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Endereco_Cliente");
            });

            modelBuilder.Entity<Feriado>(entity =>
            {
                entity.HasKey(e => e.IdFeriado)
                    .HasName("PK__Feriados__8A3082C41A93AFAA");
            });

            modelBuilder.Entity<FormaPagamento>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagamento)
                    .HasName("PK__FormaPag__848425F8EF8546EE");
            });

            modelBuilder.Entity<Parcela>(entity =>
            {
                entity.HasKey(e => e.IdParcela)
                    .HasName("PK__Parcela__8E1ACADDF495C30D");

                entity.Property(e => e.FormaPagamento).IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.Property(e => e.ObservacaoEmprestimo).IsUnicode(false);

                entity.HasOne(d => d.IdEmprestimoNavigation)
                    .WithMany(p => p.Parcelas)
                    .HasForeignKey(d => d.IdEmprestimo)
                    .HasConstraintName("FK_Emprestimo_Parcela");
            });

            modelBuilder.Entity<ViewAplicacaoCliente>(entity =>
            {
                entity.ToView("View_AplicacaoCliente");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.CodOrder).IsUnicode(false);

                entity.Property(e => e.NomeAtendente).IsUnicode(false);

                entity.Property(e => e.NomeCliente).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRecebimento>(entity =>
            {
                entity.ToView("View_Recebimento");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.CodOrder).IsUnicode(false);

                entity.Property(e => e.NomeCliente).IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRefinanciar>(entity =>
            {
                entity.ToView("View_Refinanciar");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.NomeCliente).IsUnicode(false);

                entity.Property(e => e.ReferenciaEmprestimo).IsUnicode(false);

                entity.Property(e => e.Telefone1).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
