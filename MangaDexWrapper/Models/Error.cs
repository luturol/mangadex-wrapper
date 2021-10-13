using System;
using System.Net;

namespace MangaDexWrapper.Models
{
    public record Error
    {
        public string Id { get; init; }
        public HttpStatusCode Status { get; init; }
        public string Title { get; init; }
        public string Detail { get; init; }
        public Object Context { get; init; }
    }
}
