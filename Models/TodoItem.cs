namespace AspControllerAPI.Models;

public class TodoItem
{
    public int Id {get; set;}
    public int TodoListId {get; set;}
    public string? Name {get; set;}
    public bool IsComplete {get; set;}
    public TodoList? List {get; set;}
}