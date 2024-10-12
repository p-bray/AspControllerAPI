using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspControllerAPI.Models;

namespace AspControllerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListsController : ControllerBase
    {
        private readonly TodoContext _context;
        public TodoListsController(TodoContext context)
        {
            _context = context;
        }

        //GET method for api/TodoLists
        //GET method for api/TodoLists/{id}

        [HttpGet]
        //We hve to return an IEnumberable in the action results here since it's more than one object that is returned
        public async Task<ActionResult<IEnumerable<TodoList>>> GetTodoLists()
        {
            return await _context.TodoLists.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoList>> GetTodoList(int id)
        {
            var todoList = await _context.TodoLists.FindAsync(id); 
            if(todoList is null) return NotFound();
            return todoList;
        }

        [HttpPost]
        public async Task<IActionResult> PostTodoList(TodoList list)
        {
           _context.TodoLists.Add(list);

           await _context.SaveChangesAsync();

           return CreatedAtAction(nameof(GetTodoList), new {id = list.Id}, list); 
        }














    }
}