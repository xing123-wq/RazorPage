using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Pages.Entitys
{
    public class Articles
    {
        public object PublishDateTime { get; internal set; }
        public RegisterUser Author { get; internal set; }
        public string Body { get; internal set; }
        public string Title { get; internal set; }
        public List<Keyword> Keywords { get; internal set; }
    }
}
