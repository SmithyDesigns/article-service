using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MyProject.src.Domain.ValueObjects;

namespace MyProject.Models.Dto
{
    public class ArticleDto
    {
        public required string? Title { get; set; }
        public required string? Html { get; set; }
    }
}