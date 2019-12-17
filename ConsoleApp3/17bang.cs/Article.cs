using System;

namespace ConsoleApp3
{
    public class Article : Content
    {
        //public Article(string kind) : base(kind) { }
        public string Title { get; set; }
        internal void TitleContent(string Title)
        {
            this.Title = Title;
            if (Title == "    ")
            {
                Console.WriteLine(Title.Remove(1, Title.Length - 1));
            }
            else
            {
                //do nothing
            }
            if (Title == " abc  ")
            {
                Console.WriteLine(Title.Trim());
            }
            else
            {
                //do nothing
            }



        }
        public void MoneyAeount(int reward)
        {
            Console.WriteLine("覆盖" + reward + "了");
        }
        public void Publish()
        {
            Author.HelpMony -= 1;
        }
    }
    //确保文章（Article）的标题不能为null值，
    //也不能为一个或多个空字符组成的字符串，而且如果标题前后有空格，也予以删除
    //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、
    //17bang、管理员等敏感词。
    //确保用户（User）的密码（Password）：
    //长度不低于6
    //必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成
    //实现GetCount(string container, string target)方法，
    //可以统计出container中有多少个target
    //不使用string自带的Join()方法，定义一个mimicJoin()方法，
    //能将若干字符串用指定的分隔符连接起来，
    //比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d
}
