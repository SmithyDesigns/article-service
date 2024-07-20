using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyProject.src.Domain.ValueObjects;

namespace MyProject.src.Application.Dto
{
    public class FindDto
    {
        private int Id { get; set;}
        public required string? Title { get; set; }
    }
}