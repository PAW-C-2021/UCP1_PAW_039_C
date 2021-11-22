using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class Student
    {
        public int Idstudent { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameStudent { get; set; }
        public int? NoHp { get; set; }
    }
}
