using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFactory.简单工厂;
using SampleFactory.工厂方法设计模式;

namespace SampleFactory
{
    class Program
    {
        //简单工厂的优点是：1.解决了客户端直接创建对象的责任,仅仅承担使用的责任，实现了责任隔离
        //2.代码复用
        static void Main(string[] args)
        {
            //使用简单工厂模式进行创建
            var yellow = HumanFactorySample.CreatHuman<YellowHuman>();
            yellow.GetColor();
            yellow.Talk();
            Console.ReadKey();


            //使用工厂方法设计模式进行创建
            var HumanFactory = new HumanFactory();
            var newyellow = HumanFactory.CreatHuman<YellowHuman>();
            newyellow.GetColor();
            newyellow.Talk();
        }
    }
}
