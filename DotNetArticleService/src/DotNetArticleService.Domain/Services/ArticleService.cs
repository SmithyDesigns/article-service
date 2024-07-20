using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetArticleService.Domain.Entities;
using DotNetArticleService.Domain.Interfaces;
using MyProject.Data;
using MyProject.Interfaces;
using MyProject.Models;
using MyProject.Models.Dto;
using MyProject.src.Application.Dto;
using MyProject.src.Domain.Models.Exceptions;

namespace MyProject.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleService _articleRepository;

        public ArticleService(IArticleService articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<Article> Create(CreateDto createDto)
        {
            if (string.IsNullOrEmpty(createDto.Title) || string.IsNullOrEmpty(createDto.Html))
            {
                throw new ArgumentException("Title and Html are required.", nameof(createDto));
            }

            try
            {
                return await _articleRepository.Create(createDto);
            }
            catch (DbUpdateException ex)
            {
                throw new ArgumentException("Failed to create article. Please check the database connection.", nameof(createDto), ex);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("An error occurred while creating the article.", nameof(createDto), ex);
            }
        }

        public async Task<Article> Find(FindDto findDto)
        {
            if (findDto == null)
            {
                throw new ArgumentNullException(nameof(findDto), "FindDto is required");
            }

            try
            {
                return await _articleRepository.Find(findDto);
            }
            catch (Exception)
            {
                throw new NotFoundException("Article not found");
            }
        }

        // public async Task<Article> UpdateAsync(UpdateDTO article)
        // {
        //     return await _articleRepository.UpdateAsync(article);
        // }

        // public async Task<Article> DeleteAsync(int id)
        // {
        //     return await _articleRepository.DeleteAsync(id);
        // }

        // public async Task<IEnumerable<Article>> GetAllAsync()
        // {
        //     return await _articleRepository.GetAllAsync();
        // }
    }
}