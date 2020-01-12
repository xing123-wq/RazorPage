
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ConsoleApp3
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private DBhelper _dBhelper;
        private string _name { get; set; }
        public Student()//减少newDBhelper的次数
        {
            if (_dBhelper == null)
            {
                _dBhelper = new DBhelper();
            }
        }
        public void Save()
        {
            _dBhelper.ExecuteNonQuery($" INSERT DREAM VALUES(N'{Name}',{Age})");
        }
        public void Delete()
        {
            _dBhelper.ExecuteNonQuery($"DELETE DREAM WHERE [Name]={_name} ");
        }
        public void Select()
        {
            object selrct = _dBhelper.ExecuteScalar("SELECT COUNT(*)[Name] FROM DREAM WHERE Age>2");
            Console.WriteLine(selrct);
        }
        //思考dynamic和var的区别
        //用代码证明struct定义的类型是值类型
        internal void Information()
        {
            object[] Student = new object[5];
            string Name = "阿泰";
            Student[0] = Name;
            int Score = 99;
            Student[1] = Score;
            double GPA = 88.5;
            Student[2] = GPA;
            DateTime EnrolTime = new DateTime(12, 3, 4);
            Student[3] = EnrolTime;
            bool gender = true;//true代表男生,false代表女生.
            Student[4] = gender;
            Console.WriteLine(Student[0]);
            Console.WriteLine(Student[1]);
            Console.WriteLine(Student[2]);
            Console.WriteLine(Student[3]);
            Console.WriteLine(Student[4]);
        }
    }
    internal struct StudentInformation
    {

        internal int score;
    }

}

//构造一个能装任何数据的数组，并完成数据的读写
//使用object改造数据结构栈（Stack），并在出栈时获得出栈元素
//一起帮中用户可以被分为：访客（Visited）、注册用户（Registered）、可发布（Published）和管理员（Admin）。请据此设计一个枚举类型Role（角色），并将其用于User对象，让User对象可以角色属性。

