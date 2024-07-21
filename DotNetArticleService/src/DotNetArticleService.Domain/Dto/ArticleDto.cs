namespace DotNetArticleService.Domain.Dto
{
    public class ArticleDto
    {
        public required string? Title { get; set; }
        public required string? Html { get; set; }
    }
}