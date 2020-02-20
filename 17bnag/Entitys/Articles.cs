using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17bnag.Entitys
{
    public class Articles
    {
        public DateTime PublishDateTime { get; set; }
        public RegisterUser Author { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public List<Keyword> Keywords { get; set; }
    }
}
