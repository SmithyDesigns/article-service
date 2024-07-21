using DotNetArticleService.Domain.Dto;
using DotNetArticleService.Domain.Entities;

namespace DotNetArticleService.Domain.Interfaces
{
    public interface IArticleService
    {
        Task<Article> Create(CreateDto createDto);

        Task<Article> Find(FindDto findDto);
    }
}
