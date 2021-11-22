using System;
using System.Collections.Generic;

#nullable disable

namespace UCP1_PAW_039_C.Models
{
    public partial class Download
    {
        public int IdDownload { get; set; }
        public string Materi { get; set; }
        public string UrlMateri { get; set; }
        public string EducationalStage { get; set; }
    }
}
