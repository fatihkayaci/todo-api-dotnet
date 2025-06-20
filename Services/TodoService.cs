using TodoAPI.DTOs;
using TodoAPI.Interfaces;
using TodoAPI.Models;

namespace TodoAPI.Service
{
    public class TodoService:ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<List<TodoResponseDto>> GetAllAsync()
        {
            var todos = await _todoRepository.GetAllAsync();
            var responseDtos = todos.Select(todo => new TodoResponseDto
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                IsCompleted = todo.IsCompleted,
                CreatedDate = todo.CreatedDate
            }).ToList();
            return responseDtos;
        }

        public async Task<TodoResponseDto> CreateAsync(CreateTodoDto createDto)
        {
            var todo = new Todo
            {
                Title = createDto.Title,
                Description = createDto.Description
            };
            var createdTodo = await _todoRepository.CreateAsync(todo);
            var responseDto = new TodoResponseDto
            {
                Id = createdTodo.Id,
                Title = createdTodo.Title,
                Description = createdTodo.Description,
                IsCompleted = createdTodo.IsCompleted,
                CreatedDate = createdTodo.CreatedDate,
            };
            return responseDto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _todoRepository.DeleteAsync(id);
        }

        public async Task<TodoResponseDto?> GetByIdAsync(int id)
        {
            var todo = await _todoRepository.GetByIdAsync(id);
            if (todo == null) return null;
            var response = new TodoResponseDto
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                IsCompleted = todo.IsCompleted,
                CreatedDate = todo.CreatedDate
            };
            return response;
        }

        public async Task<TodoResponseDto?> UpdateAsync(int id, UpdateTodoDto updateDto)
        {
            var existingTodo = await _todoRepository.GetByIdAsync(id);
            if (existingTodo == null) return null;
            
            if (updateDto.Title != null)
                existingTodo.Title = updateDto.Title;
                
            if (updateDto.Description != null)
                existingTodo.Description = updateDto.Description;
                
            if (updateDto.IsCompleted.HasValue)
                existingTodo.IsCompleted = updateDto.IsCompleted.Value;
            
            var updatedTodo = await _todoRepository.UpdateAsync(id, existingTodo);
            if (updatedTodo == null) return null;
            
            // 4. DTO'ya çevir
            return new TodoResponseDto
            { 
                Id = updatedTodo.Id,
                Title = updatedTodo.Title,
                Description = updatedTodo.Description,
                IsCompleted = updatedTodo.IsCompleted,
                CreatedDate = updatedTodo.CreatedDate
            };
        }
    }
}