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
        public virtual DbSet<Despesa> Despesas { get; set; }
        public virtual DbSet<DespesaFuncionario> DespesaFuncionarios { get; set; }
        public virtual DbSet<DespesaMensal> DespesaMensals { get; set; }
        public virtual DbSet<Emprestimo> Emprestimos { get; set; }
        public virtual DbSet<Feriado> Feriados { get; set; }
        public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public virtual DbSet<Parcela> Parcelas { get; set; }
        public virtual DbSet<ViewProducao> ViewProducaos { get; set; }
        public virtual DbSet<ViewRecebimento> ViewRecebimentos { get; set; }
        public virtual DbSet<ViewRefinanciamento> ViewRefinanciamentos { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Atendente>(entity =>
            {
                entity.HasKey(e => e.IdAtendente)
                    .HasName("PK__Atendent__B9FB093867D49D57");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__885457EE08EC217E");

                entity.Property(e => e.DataAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ebairro).IsUnicode(false);

                entity.Property(e => e.Ecep).IsUnicode(false);

                entity.Property(e => e.Ecidade).IsUnicode(false);

                entity.Property(e => e.Ecomplemento).IsUnicode(false);

                entity.Property(e => e.Eestado).IsUnicode(false);

                entity.Property(e => e.Elagradouro).IsUnicode(false);

                entity.Property(e => e.Nreferencia1).IsUnicode(false);

                entity.Property(e => e.Nreferencia2).IsUnicode(false);

                entity.Property(e => e.Nreferencia3).IsUnicode(false);

                entity.Property(e => e.Pesquisa).HasComputedColumnSql("(((((((([telResidencial]+' ')+[telCelular2])+' ')+[telCelularzap])+' ')+[nomeClienteNormalizado])+' ')+[cpf])", true);

                entity.Property(e => e.Rbairro).IsUnicode(false);

                entity.Property(e => e.Rcep).IsUnicode(false);

                entity.Property(e => e.Rcidade).IsUnicode(false);

                entity.Property(e => e.Rcomplemento).IsUnicode(false);

                entity.Property(e => e.Restado).IsUnicode(false);

                entity.Property(e => e.Rlagradouro).IsUnicode(false);

                entity.Property(e => e.SalarioLiquido).HasDefaultValueSql("((0))");

                entity.Property(e => e.TelefoneR1).IsUnicode(false);

                entity.Property(e => e.TelefoneR2).IsUnicode(false);

                entity.Property(e => e.TelefoneR3).IsUnicode(false);
            });

            modelBuilder.Entity<Despesa>(entity =>
            {
                entity.HasKey(e => e.IdDespesa)
                    .HasName("PK__Despesa__6056E36108EC12DD");
            });

            modelBuilder.Entity<DespesaFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdDespesaFuncionario)
                    .HasName("PK__DespesaF__0ABB4524DEDABA42");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdAtendenteNavigation)
                    .WithMany(p => p.DespesaFuncionarios)
                    .HasForeignKey(d => d.IdAtendente)
                    .HasConstraintName("FK_DespesaFuncionario_Atendente");

                entity.HasOne(d => d.IdDespesaNavigation)
                    .WithMany(p => p.DespesaFuncionarios)
                    .HasForeignKey(d => d.IdDespesa)
                    .HasConstraintName("FK_DespesaFuncionario_Despesa");
            });

            modelBuilder.Entity<DespesaMensal>(entity =>
            {
                entity.HasKey(e => e.IdDespesaMensal)
                    .HasName("PK__DespesaM__06C6A709E9D60237");

                entity.Property(e => e.IdDespesaMensal).IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Emprestimo>(entity =>
            {
                entity.HasKey(e => e.IdEmprestimo)
                    .HasName("PK__Empresti__4B4C886025C510BF");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataCadastroAlteracao).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReferenciaEmprestimo).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Emprestimos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Cliente_Emprestimo");
            });

            modelBuilder.Entity<Feriado>(entity =>
            {
                entity.HasKey(e => e.IdFeriado)
                    .HasName("PK__Feriados__77769448864EA0DF");
            });

            modelBuilder.Entity<FormaPagamento>(entity =>
            {
                entity.HasKey(e => e.IdFormaPagamento)
                    .HasName("PK__FormaPag__B30C1EFD2CDBA01D");
            });

            modelBuilder.Entity<Parcela>(entity =>
            {
                entity.HasKey(e => e.IdParcela)
                    .HasName("PK__Parcela__D965304ECD7C64DD");

                entity.HasOne(d => d.IdEmprestimoNavigation)
                    .WithMany(p => p.Parcelas)
                    .HasForeignKey(d => d.IdEmprestimo)
                    .HasConstraintName("FK_Emprestimo_Parcela");
            });

            modelBuilder.Entity<ViewProducao>(entity =>
            {
                entity.ToView("ViewProducao");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.CodOrder).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRecebimento>(entity =>
            {
                entity.ToView("ViewRecebimento");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.CodOrder).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRefinanciamento>(entity =>
            {
                entity.ToView("ViewRefinanciamento");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.ReferenciaEmprestimo).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
