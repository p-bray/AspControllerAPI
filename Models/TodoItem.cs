namespace AspControllerAPI.Models;

public class TodoItem
{
    public long Id {get; set;}
    public int TodoListId {get; set;}
    public string? Name {get; set;}
    public bool IsComplete {get; set;}
    public string? SecretField {get; set;}
}

