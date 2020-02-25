using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _17bnag.Entitys
{
    public class Map
    {
        [Key]
        public int helperId { get; set; }
        public HelpRelease Help { get; set; }
        public int KeywordId { get; set; }
        public Keyword Keyword { get; set; }

    }
}
