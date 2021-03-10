using Deza.Stone;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deza.Models.Dtos
{
    public class UserDto : IDto
    {
        public string email { get; set; }

        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
    }
}
