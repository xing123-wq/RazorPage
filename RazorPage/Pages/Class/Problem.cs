using System;
using System.Collections.Generic;

namespace RazorPage
{
    public class Problem
    {
        public DateTime PublishDateTime { get; set; }
        public string Body { get; internal set; }
        public string Title { get; internal set; }
        public User Author { get; set; }
        public List<Keyword> Keywords { get; set; }
    }
}