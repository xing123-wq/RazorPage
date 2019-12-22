using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Problem : Content
    {
        //一起帮的求助可以有多个（最多10个）关键字，
        //请为其设置索引器，以便于我们通过其整数下标进行读写。
        public string[] Keyword = {
            "C#", "编程语言",
            "JavaScript", "工具软件",
            "Java", "顾问咨询", "SQL",
            "职场", "法律", ".net"
        };
        public string this[int Index]
        {
            get { return Keyword[Index]; }
            set { Keyword[Index] = value; }
        }
        //public Problem(string kind) : base(kind) { }
        internal string Title { get; set; }
        public string Body { get; set; }
        public int _reward;
        public int Reward
        {
            get { return _reward; }
            set
            {
                if (_reward > 0)
                {
                    _reward = value;
                }
                else
                {
                    //do nothing 
                }
            }
        }
        public DateTime PublishDateTime { get; set; }
        public void Publish()
        {
            Author.credit++;
            Author.HelpMony -= Reward;
        }

        public static void Load(int Id)
        {

        }
        static void Delete(int id)
        {

        }


        private readonly static repoistory _repoistory;

        public class repoistory
        {

        }
    }

}
