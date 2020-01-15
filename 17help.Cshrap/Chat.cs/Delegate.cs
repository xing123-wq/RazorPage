using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Delegate
    {
        //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
        public static int GetWater(ProvideWater provide)
        {
            Person person = new Person();
            return provide(person);
        }

        public static int assignDelegate(Person person)
        {
            return 10;
        }

        public static void assginWay()
        {
            //使用方法给委托赋值
            Person person1 = new Person();
            ProvideWater provideWater1 = new ProvideWater(assignDelegate);
            Console.WriteLine(provideWater1(person1));

            //使用匿名方法给委托赋值
            ProvideWater provideWater2 = delegate (Person person)
            {
                return 2;
            };
            Console.WriteLine(provideWater2(person1));

            //使用lambda表达式给上述委托赋值，并运行该委托
            ProvideWater provideWater3 = p => 3;
            Console.WriteLine(provideWater3(person1));

            //将ProvideWater的返回值输出
            ProvideWater provideWater4 = p => 4;
            Console.WriteLine(GetWater(provideWater4));
        }
    }
}
