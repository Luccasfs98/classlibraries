using ToDoList.Domain;

public class DataContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DataContext (Microsoft.EntityFrameworkCore.DbContextOptions<DataContext> options)
        : base(options)
        { }
    
    public Microsoft.EntityFrameworkCore.DbSet<Person> person { get ; set ;}
}