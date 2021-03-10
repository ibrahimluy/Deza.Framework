using Deza.Stone;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deza.Models.Dtos
{
    public class TokenDto : IDto
    {
        public string token { get; set; }

        public string expiration { get; set; }
    }
}

