using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Indtast27Mål.Models
{
    public partial class EgeMål
    {
        public int Id { get; set; }
        public string Kategori { get; set; }
        public double? StatusEgedal { get; set; }
        public double? StatusDanmark { get; set; }
        public double? SenesteEgedal { get; set; }
        public double? SenesteDanmark { get; set; }
        public int? Placering { get; set; }
        public string Hvad { get; set; }
        public string Hvorfor { get; set; }
        public string Initiativer { get; set; }
        public string Indikator { get; set; }
        public string Dato { get; set; }

    }
}
