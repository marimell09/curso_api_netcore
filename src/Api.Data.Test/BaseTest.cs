using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

namespace Api.Data.Test
{

  public abstract class BaseTest
  {
  }
}

public class DbTeste : IDisposable
{
  private string databaseName = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
  public ServiceProvider ServiceProvider { get; private set; }

  public DbTeste()
  {
    var serviceCollection = new ServiceCollection();
    serviceCollection.AddDbContext<MyContext>(o =>
      o.UseMySql($"Persist Security Info=True;Server=127.0.0.1;Database={databaseName};User=root;Password=dracula1!",
        new MySqlServerVersion(new Version(8,0,21)),
                mySqlOptions => mySqlOptions
                  .CharSetBehavior(CharSetBehavior.NeverAppend)),
        ServiceLifetime.Transient
    );

    ServiceProvider = serviceCollection.BuildServiceProvider();
    using (var context = ServiceProvider.GetService<MyContext>()){
      context.Database.EnsureCreated();
    }

  }


  public void Dispose()
  {
    using (var context = ServiceProvider.GetService<MyContext>()){
      context.Database.EnsureDeleted();
    }

  }
}
