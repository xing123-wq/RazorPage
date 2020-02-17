using System;
using System.Collections.Generic;

namespace RazorPage
{
    public class Problem
    {
        public DateTime PublishDateTime { get; set; }
        public string Body { get; internal set; }
        public string Title { get; internal set; }
        public string Id { get; set; }
        public RegisterUser Author { get; set; }
        public List<Keyword> Keywords { get; set; }
    }
}