using Deza.Stone;

namespace Deza.Models.Dtos
{
    public class TokenDto : IDto
    {
        public string token { get; set; }

        public string expiration { get; set; }
    }
}

