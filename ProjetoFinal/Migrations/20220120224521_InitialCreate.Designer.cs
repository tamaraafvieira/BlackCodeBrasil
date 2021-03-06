// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinal.Data;

namespace ProjetoFinal.Migrations
{
    [DbContext(typeof(ProjetoFinalContext))]
    [Migration("20220120224521_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoFinal.Models.Talento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aprendeu1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aprendeu2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Atividade1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Atividade2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CargaHoraria1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CargaHoraria2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Formacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funcao1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funcao2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Habilidades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instituicao1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instituicao2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nivel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Talento");
                });
#pragma warning restore 612, 618
        }
    }
}
