using Microsoft.EntityFrameworkCore;

namespace AspControllerAPI.Models;

public class TodoItemDTO
{
    public long Id {get; set;}
    public int TodoListId {get; set;}
    public string? Name {get; set;}
    public bool IsComplete {get; set;}

    public TodoList? List {get; set;}
}