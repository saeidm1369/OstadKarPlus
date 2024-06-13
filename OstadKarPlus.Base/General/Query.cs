using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Base.General
{
    public class Query
    {
        public int? Page { get; set; }
        public int? Length { get; set; }
        public string? Sort { get; set; }
        public string? Dir { get; set; }
        public string? Search { get; set; }
    }
}
