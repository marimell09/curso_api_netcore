using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
  public abstract class BaseEntity
  {
    //Notation que indica chave primária
    [Key]
    public Guid Id { get; set; }

    private DateTime? _createAt;

    //Propriedade do banco
    public DateTime? CreateAt
    {
        get { return _createAt; }
        set { _createAt = (value == null ? DateTime.UtcNow : value); }
    }
  public DateTime? UpdateAt { get; set; }
  }

}