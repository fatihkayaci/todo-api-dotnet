using TodoAPI.DTOs;

namespace TodoAPI.Interfaces
{
    public interface ITodoService
    {
        Task<List<TodoResponseDto>> GetAllAsync();
        Task<TodoResponseDto?> GetByIdAsync(int id);
        Task<TodoResponseDto> CreateAsync(CreateTodoDto createDto);
        Task<TodoResponseDto?> UpdateAsync(int id, UpdateTodoDto updateDto);
        Task<bool> DeleteAsync(int id);
    }
}