using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Data;
using TodoAPI.Interfaces;
using TodoAPI.Models;

namespace TodoAPI.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;
        public TodoRepository(TodoContext context)
        {
            _context = context;
        }
        public async Task<List<Todo>> GetAllAsync()
        {
            return await _context.Todos
            .OrderByDescending(t => t.CreatedDate)
            .ToListAsync();
        }
        public async Task<Todo?> GetByIdAsync(int id)
        {
            return await _context.Todos
            .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<Todo> CreateAsync(Todo todo)
        {
            todo.CreatedDate = DateTime.Now;

            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
            return todo;
        }
        public async Task<Todo?> UpdateAsync(int id, Todo todo)
        {
            var existingTodo = await _context.Todos.FindAsync(id);
            
            if (existingTodo == null)
                return null;

            existingTodo.Title = todo.Title;
            existingTodo.Description = todo.Description;
            existingTodo.IsCompleted = todo.IsCompleted;
            await _context.SaveChangesAsync();
            return existingTodo;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null) return false;

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}