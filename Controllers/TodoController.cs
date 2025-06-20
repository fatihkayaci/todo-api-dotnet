using Microsoft.AspNetCore.Mvc;
using TodoAPI.DTOs;
using TodoAPI.Interfaces;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        // GET: api/todo
        [HttpGet]
        public async Task<ActionResult<List<TodoResponseDto>>> GetTodos()
        {
            var todos = await _todoService.GetAllAsync();
            return Ok(todos);
        }

        // GET: api/todo/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoResponseDto>> GetTodo(int id)
        {
            var todo = await _todoService.GetByIdAsync(id);
            
            if (todo == null)
                return NotFound($"Todo with ID {id} not found.");
                
            return Ok(todo);
        }

        // POST: api/todo
        [HttpPost]
        public async Task<ActionResult<TodoResponseDto>> CreateTodo(CreateTodoDto createDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdTodo = await _todoService.CreateAsync(createDto);
            
            return CreatedAtAction(
                nameof(GetTodo), 
                new { id = createdTodo.Id }, 
                createdTodo
            );
        }

        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<TodoResponseDto>> UpdateTodo(int id, UpdateTodoDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedTodo = await _todoService.UpdateAsync(id, updateDto);
            
            if (updatedTodo == null)
                return NotFound($"Todo with ID {id} not found.");
                
            return Ok(updatedTodo);
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodo(int id)
        {
            var result = await _todoService.DeleteAsync(id);
            
            if (!result)
                return NotFound($"Todo with ID {id} not found.");
                
            return NoContent(); // 204 No Content
        }
    }
}