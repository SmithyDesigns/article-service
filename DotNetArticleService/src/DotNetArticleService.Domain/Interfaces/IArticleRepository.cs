using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetArticleService.Domain.Entities;
using MyProject.Models;
using MyProject.Models.Dto;
using MyProject.src.Application.Dto;

namespace MyProject.Interfaces
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