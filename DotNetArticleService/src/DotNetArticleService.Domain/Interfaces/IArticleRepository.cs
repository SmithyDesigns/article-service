using DotNetArticleService.Domain.Dto;
using DotNetArticleService.Domain.Entities;

namespace DotNetArticleService.Domain.Interfaces
{
    public interface IArticleRepository
    {
        Task<Article> Create(CreateDto CreateDto);
        Task<Article> Find(FindDto findDto);
        // Task<Article> UpdateAsync(UpdateDTO Article);
        // Task<Article> DeleteAsync(int id);
        // Task<IEnumerable<Article>> GetAllAsync();
    }
}