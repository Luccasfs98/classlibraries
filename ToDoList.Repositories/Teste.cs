

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class Teste : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseMySql("Data Source=ToDo.db");

            return new DataContext(optionsBuilder.Options);
        }
    }