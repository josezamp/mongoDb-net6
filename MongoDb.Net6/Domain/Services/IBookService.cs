using Shared.DTO;

namespace Domain.Services
{
    public interface IBookService
    {
        Task<BookDto> GetBook(string name);
        Task<bool> AddBookAsync(BookDto bookDto);
    }
}
