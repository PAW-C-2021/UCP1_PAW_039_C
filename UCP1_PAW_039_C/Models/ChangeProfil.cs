using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class ChangeProfil
    {
        public int IdChangeProfil { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? DateofBirth { get; set; }
        public int? PhoneNumber { get; set; }
        public string Addres { get; set; }
    }
}
