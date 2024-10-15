using Microsoft.EntityFrameworkCore;

namespace AspControllerAPI.Models;

public class TodoList
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public List<TodoItem>? Items {get; set;}

    public void NewItem(TodoItem item)
    {
        Items.Add(item);
        item.TodoListId = Id;
    }
}