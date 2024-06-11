using Microsoft.EntityFrameworkCore;
namespace EventPlanningSystemRestAPI.models;

public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
{
    public DbSet<User> Users {get; set;}
}
