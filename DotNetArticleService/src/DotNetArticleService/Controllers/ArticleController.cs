using DotNetArticleService.Domain.Entities;
using DotNetArticleService.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models.Dto;
using MyProject.src.Application.Dto;

namespace DotNetArticleService.Controllers
{
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [Route("api/articles/create")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDto createDto)
        {
            if (createDto == null)
            {
                return BadRequest("CreateDto is required");
            }

            var article = await _articleService.Create(createDto);

            var articleDto = new ArticleDto
            {
                Title = article.Title,
                Html = article.Html
            };

            return Ok(articleDto);
        }

        [Route("api/articles")]
        [HttpGet]
        public async Task<IActionResult> Get([FromBody] FindDto findDto)
        {
            if (findDto == null)
            {
                return BadRequest("FindDto is required");
            }

            var article = await _articleService.Find(findDto);
            return Ok(article);
        }
    }
}
