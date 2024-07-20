using DotNetArticleService.Domain.Entities;
using MyProject.Models.Dto;
using MyProject.src.Application.Dto;

namespace DotNetArticleService.Domain.Interfaces
{
    public interface IArticleService
    {
        Task<Article> Create(CreateDto createDto);

        Task<Article> Find(FindDto findDto);
    }
}
