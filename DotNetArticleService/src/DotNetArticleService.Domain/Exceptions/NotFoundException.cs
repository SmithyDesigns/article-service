using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetArticleService.Domain.Exceptions
{
    public class NotFoundException(string message) : Exception(message)
    {
    }
}