using Microsoft.EntityFrameworkCore;

namespace AspControllerAPI.Models;

public class TodoList
{
    public int Id {get; set;}
    public string? Name {get; set;}
}