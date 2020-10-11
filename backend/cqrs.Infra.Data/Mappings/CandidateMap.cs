using cqrs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cqrs.Infra.Data.Mappings
{
    public class CandidateMap : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(c => c.UrlLinkedin)
                .HasColumnName("url_linkedin")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(c => c.UsuarioGithub)
                .HasColumnName("usuario_github")
                .HasColumnType("varchar(150)")
                .HasMaxLength(150);

        }
    }
}
