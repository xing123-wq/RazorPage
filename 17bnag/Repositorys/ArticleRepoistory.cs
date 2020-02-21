using _17bnag.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17bnag.Repositorys
{
    public class ArticleRepoistory
    {
        static IList<Articles> Articless;
        static ArticleRepoistory()
        {
            RegisterUser pk = new RegisterUser { Id = 1, Name = "彭昆" };
            RegisterUser at = new RegisterUser { Id = 2, Name = "阿泰" };
            RegisterUser cy = new RegisterUser { Id = 3, Name = "陈元" };
            RegisterUser fg = new RegisterUser { Id = 4, Name = "飞哥" };
            Keyword sql = new Keyword { Id = 1, Name = "SQL" };
            Keyword java = new Keyword { Id = 2, Name = "JAVA" };
            Keyword CSharp = new Keyword { Id = 3, Name = "C#" };
            Keyword javascript = new Keyword { Id = 4, Name = "JavaScript" };
            Keyword html5 = new Keyword { Id = 5, Name = "HTML5" };
            Keyword css = new Keyword { Id = 6, Name = "CSS" };
            Keyword linq = new Keyword { Id = 7, Name = "Linq" };
            Keyword ajax = new Keyword { Id = 8, Name = "AJAX" };
            //模拟从数据库取数据
            Articless = new List<Articles>
            {
              new Articles
              {
                PublishDateTime = new DateTime(2020, 2, 1),
                Author = pk,
                Id=1,
                Body = "期望功能：当U盘被拔下后，系统崩溃或者退出。" +
                "经历：之前看到别人做过，按我正常的理解，系统本身会有检查U盘存在与否的功能，" +
                "但是别人并没有这样做，也就是说他并没有动系统的代码，而是直接对程序一通操作，" +
                "然后就加密了。哪位大神有相关经验或者思路，求一个——————……",
                Title = " 如何使用U盘防护系统的运行",
                Keywords = new List<Keyword>
                {
                   sql,java,CSharp
                },

              },
              new Articles
              {
                PublishDateTime = new DateTime(2019, 10, 7),
                Author = at,
                Id=2,
                Body = "……",
                Title = " 为什么在给变量a赋值后，再使a=a++之后，输出a的值没有变化。",
                Keywords = new List<Keyword>
                {
                   linq,css,ajax
                },

              },
              new Articles
              {
                PublishDateTime = new DateTime(2020, 1, 21),
                Author = cy,
                Id=3,
                Body = "RT，也不知道描述的清楚不清楚。求一个思路……c",
                Title = " 有一个自定义UI控件，此控件使用在不同的系统中会有不同的呈现，" +
                "之前的做法是各种switch case，阅读代码时让人很难受，另外新创建一个用到此控件的系统，" +
                "要修改代码的地方也多，只要有swich case 的地方都要再加一个case。" +
                "请教一个好一些的方式来处理这个问题，目的是让代码更加清楚",
                Keywords = new List<Keyword>
                {
                    html5,javascript,sql
                },
              },
              new Articles
              {
                  PublishDateTime=new DateTime(2017,12,4),
                  Author=fg,
                  Body="理想状态上，经过25周的学习，同学们应该参照“一起帮”，" +
                  "完成以下全部功能。实际上，这也是“一起帮”的教学的核心目的之一（另外一个目的是通过面试拿到offer，^_^）。" +
                  "以下功能，应完成的优先级从上往下依次递减。标注意思为：[讲]：会在课堂上予以讲解示例并完成[练]：" +
                  "会以作业的形式布置给同学们，要求同学们必须完成[选]：鼓励学有余力的同学予以完成用户权限注册/登录" +
                  "，其中又包括：[讲]输入验证：常规/Ajax密码加密记住我（自动登录）" +
                  "验证码邀请人返回上一页 个人资料[练]联系方式[讲]找回密码[讲]修改密码",
                  Title="源栈培训：功能索引",
                  Keywords=new List<Keyword>
                  {
                      html5,java,sql
                  }
              }
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageindex">第几页</param>
        /// <param name="pagesize">每一页取多少条数据</param>
        /// <returns></returns>
        public List<Articles> Get(int pageindex, int pagesize)
        {
            return Articless.OrderByDescending(p => p.PublishDateTime)
                .Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }
    }
}
