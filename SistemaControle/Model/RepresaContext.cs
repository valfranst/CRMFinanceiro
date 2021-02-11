using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaControle.Arquitetura;

#nullable disable

namespace SistemaControle.Model
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
        public virtual DbSet<DespesaMensal> DespesaMensals { get; set; }
        public virtual DbSet<Emprestimo> Emprestimos { get; set; }
        public virtual DbSet<Feriado> Feriados { get; set; }
        public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public virtual DbSet<Parcela> Parcelas { get; set; }
        public virtual DbSet<ViewAplicacaoCliente> ViewAplicacaoClientes { get; set; }
        public virtual DbSet<ViewDespesaMensal> ViewDespesaMensals { get; set; }
        public virtual DbSet<ViewEmprestimoView> ViewEmprestimoViews { get; set; }
        public virtual DbSet<ViewParcelaEmprestimo> ViewParcelaEmprestimos { get; set; }
        public virtual DbSet<ViewRecebimento> ViewRecebimentos { get; set; }
        public virtual DbSet<ViewRefinanciar> ViewRefinanciars { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendente>(entity =>
            {
                entity.HasKey(e => e.IdAtendente)
                    .HasName("PK__Atendent__B9FB093867D49D57");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__885457EE08EC217E");

                entity.Property(e => e.DataCadastro).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pesquisa).HasComputedColumnSql("(((((((([telResidencial]+' ')+[telCelular2])+' ')+[telCelularzap])+' ')+[nomeClienteNormalizado])+' ')+[cpf])", true);

                entity.Property(e => e.SalarioLiquido).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DespesaMensal>(entity =>
            {
                entity.HasKey(e => e.IdDespesaMensal)
                    .HasName("PK__DespesaM__06C6A7095BAC22A7");

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
                    .HasName("PK__Feriados__777694487CA6246C");
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

            modelBuilder.Entity<ViewAplicacaoCliente>(entity =>
            {
                entity.ToView("View_AplicacaoCliente");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.CodOrder).IsUnicode(false);
            });

            modelBuilder.Entity<ViewDespesaMensal>(entity =>
            {
                entity.ToView("View_DespesaMensal");
            });

            modelBuilder.Entity<ViewEmprestimoView>(entity =>
            {
                entity.ToView("View_EmprestimoView");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);
            });

            modelBuilder.Entity<ViewParcelaEmprestimo>(entity =>
            {
                entity.ToView("View_ParcelaEmprestimo");
            });

            modelBuilder.Entity<ViewRecebimento>(entity =>
            {
                entity.ToView("View_Recebimento");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.CodOrder).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRefinanciar>(entity =>
            {
                entity.ToView("View_Refinanciar");

                entity.Property(e => e.CodEmprestimo).IsUnicode(false);

                entity.Property(e => e.ReferenciaEmprestimo).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
