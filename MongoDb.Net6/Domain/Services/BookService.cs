using AutoMapper;
using Domain.Entities;
using Persistence.Repository;
using Shared.DTO;

namespace Domain.Services
{
    public class BookService : IBookService
    {
        private readonly MongoRepository<Book> _mongoRepository;
        private readonly IMapper _mapper;
        public BookService(MongoRepository<Book> mongoRepository, IMapper mapper)
        {
            _mongoRepository = mongoRepository;
            _mapper = mapper;
        }
        public async Task<BookDto> GetBook(string name)
        {
            var book = await _mongoRepository.GetOneAsync(name,"books");
            var result = _mapper.Map<BookDto>(book);
            return result;
        }
        public async Task<bool> AddBookAsync(BookDto bookDto)
        {
            var book = _mapper.Map<Book>(bookDto);
            var result = await _mongoRepository.InsertAsync(book, "books");
            return result;
        }
    }
}
