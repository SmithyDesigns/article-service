namespace DotNetArticleService.Domain.Dto
{
    public class CreateDto
    {
        public required string? Title { get; set; }
        public required string? Html { get; set; }
    }
}