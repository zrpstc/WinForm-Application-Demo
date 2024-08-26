using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//原型设计模式
//为啥研究原型设计模式：因为当你new一个新对象的时候，每new一次都需要执行一次构造函数，如果构造函数的执行时间很长，那么多次New对象时
//会大大拉低程序执行效率，因此一般在初始化信息不发生变化的前提下，克隆是最好的方法，这既隐藏了对象的创建细节，又大大提升了性能————大话设计模式
namespace Prototype
{
    //补充知识点：深浅拷贝
    class Program
    {
        static void Main(string[] args)
        {
            //直接调用Mail
            Mail mail = new Mail();
            mail.SetMailInfo(new AdvTemplate1());
            //使用for循环给很多人发邮件非常耗时
            //如果改用多线程执行SendMail。但是存在的问题是另一个线程执行来的时候会覆盖mail这样线程可能不安全


            ///////
            //解决办法是：将Mail继承ICloneable接口，实现Clone方法，这样在多线程环境下也不会出现上述的问题
            //////
            for(int i = 0;i < 5; i++)
            {
                //
                var mailClone = (Mail)mail.Clone();
                //

                ////原本这里是直接调用new出来的初始化对象
                //==========================================================
                //为什么可以直接采用new却不用而采用这种clone的方式进行呢？
                //1.性能优良
                //2.逃避构造函数的约束

                //那么原型模式的使用场景是什么？
                //1.资源优化场景
                //2.性能和安全要求的场景
                //3.一个对象多个修改者的场景
                //==========================================================
                mailClone.appellation = "先生/女士";
                mailClone.receiver = "@tyut.com";
                
                SendMail(mailClone);

                
            }
            //===========================================================
            Console.WriteLine("=========================");
            Thing thing = new Thing();
            thing.SetValue("曹操");
            Console.WriteLine(thing.GetValue());
            Thing thingclone = (Thing)thing.Clone();//第一次输出还未改
            thingclone.SetValue("周瑜");//此时thing指向的内容已经被修改
            Console.WriteLine(thing.GetValue());
            Console.WriteLine(thingclone.GetValue());
            //打印输出的两个值都是“周瑜”
            //因为这里是浅拷贝，即拷贝引用，是一个指向内存数据区域的地址，更改了内存中存储的值之后，二者指向的都是一个内容了

            Console.Read();
            
        }

        private static void SendMail(Mail mail)
        {
            Console.WriteLine($"称谓:{mail.appellation}\t" +
                $"收件人:{mail.receiver}\t" +
                $"标题:{mail.subject}\t" +
                $"内容:{mail.context}\t" +
                $"尾部:{mail.tail}\t"
            );
            //Console.ReadKey();
        }
    }
}

