﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ExampleApp.Models
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExp { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
