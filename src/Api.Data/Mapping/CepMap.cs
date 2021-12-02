using Api.Domain.Dtos;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
  public class CepMap : IEntityTypeConfiguration<CepEntity>
  {
    public void Configure(EntityTypeBuilder<CepEntity> builder)
    {
      builder.ToTable("Cep");
      builder.HasKey(u => u.Id);

      builder.HasIndex(u => u.Cep)
              .IsUnique();

      builder.HasOne(m => m.Municipio)
              .WithMany(c => c.Ceps);
    }
  }
}