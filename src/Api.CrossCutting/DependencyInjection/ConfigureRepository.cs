using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
  public class ConfigureRepository
  {
    public static void ConfigureDependencyRepository(IServiceCollection serviceCollection)
    {
      serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
      serviceCollection.AddScoped<IUserRepository, UserImplementation>();

      serviceCollection.AddDbContext<MyContext>(
          options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=dracula1!"));
          //options => options.UseSqlServer("Server=.\\SQLEXPRESS;Database=dbapi;Trusted_Connection=True"));

    }


  }
}