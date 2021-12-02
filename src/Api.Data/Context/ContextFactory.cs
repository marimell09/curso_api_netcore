using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Api.Data.Context
{
  public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
  {
    public MyContext CreateDbContext(string[] args)
    {
        //Usado para Criar as migrações
        var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=dracula1!";

        var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
        optionsBuilder.UseMySql (connectionString, new MySqlServerVersion(new Version(8,0,21)),
          mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend)
        );

        //var connectionString = "Server=.\\SQLEXPRESS;Database=dbapi;Trusted_Connection=True";
        //optionsBuilder.UseSqlServer (connectionString);
        return new MyContext(optionsBuilder.Options);
    }
  }
}