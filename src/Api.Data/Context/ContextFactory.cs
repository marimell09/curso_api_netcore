using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
  public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
  {
    public MyContext CreateDbContext(string[] args)
    {
        //Usado para Criar as migrações
        var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=dracula1!";
        var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
        optionsBuilder.UseMySql (connectionString);
        return new MyContext(optionsBuilder.Options);
    }
  }
}