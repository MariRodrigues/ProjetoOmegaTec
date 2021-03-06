// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OmegaTec.Data;

namespace OmegaTec.Migrations
{
    [DbContext(typeof(OmegaTecContext))]
    partial class OmegaTecContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OmegaTec.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cnpj")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("OmegaTec.Models.Tarefa", b =>
                {
                    b.Property<int>("TarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int");

                    b.HasKey("TarefaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("OmegaTec.Models.Tarefa", b =>
                {
                    b.HasOne("OmegaTec.Models.Cliente", "NomeCliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
