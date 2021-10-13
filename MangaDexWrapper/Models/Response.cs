using System.Collections.Generic;

namespace MangaDexWrapper.Models
{
    public record Response
    {
        public string Result { get; set; }
        public List<Error> Errors { get; init; }
    }
}