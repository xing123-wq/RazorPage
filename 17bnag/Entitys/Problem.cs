using System;
using System.Collections.Generic;

namespace _17bnag.Entitys
{
    public class Problem
    {
        public DateTime PublishDateTime { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
        public RegisterUser Author { get; set; }
        public List<Keyword> Keywords { get; set; }
    }
}