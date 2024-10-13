using AspControllerAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AspControllerAPI.Models;

public class TodoContext : DbContext
{
    public TodoContext (DbContextOptions<TodoContext> options) : base(options) {}

    public DbSet<TodoItem> TodoItems {get; set;} = null!;
    public DbSet<TodoList> TodoLists {get; set;} = null!;
}

