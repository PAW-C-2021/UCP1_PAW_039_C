using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class Login
    {
        public int IdLogin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginStatus { get; set; }
    }
}
