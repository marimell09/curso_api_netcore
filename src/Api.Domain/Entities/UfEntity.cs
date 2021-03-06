using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Entities;

namespace Api.Domain.Dtos
{
    public class UfEntity : BaseEntity
    {

      [Required]
      [MaxLength(2)]
      public string Sigla { get; set; }

      [Required]
      [MaxLength(45)]
      public string Nome { get; set; }

      public IEnumerable<MunicipioEntity> Municipios { get; set; }
    }
}