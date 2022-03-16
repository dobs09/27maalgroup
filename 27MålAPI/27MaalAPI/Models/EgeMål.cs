using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace _27MaalAPI.Models
{
    public partial class EgeMål
    {
        public int Id { get; set; }
        public string Kategori { get; set; }
        public string? StatusEgedal { get; set; }
        public string? StatusDanmark { get; set; }
        public string? SenesteEgedal { get; set; }
        public string? SenesteDanmark { get; set; }
        public string? Placering { get; set; }
        public string Hvad { get; set; }
        public string Hvorfor { get; set; }
        public string Initiativer { get; set; }
        public string Indikator { get; set; }
        public string Dato { get; set; }
    }
}
