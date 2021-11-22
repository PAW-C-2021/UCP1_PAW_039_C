using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class EditProfil
    {
        public int IdEditProfil { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public int? PhoneNumber { get; set; }
        public string Addres { get; set; }
    }
}
