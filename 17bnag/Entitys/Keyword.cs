using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _17bnag.Entitys
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<HelpRelease> helps { get; set; }

    }
}