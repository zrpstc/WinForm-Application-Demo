using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//有且只有一个实例
namespace SingleDesignModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造函数私有无法从外部完成创建
            //只能调用自身的
            //指向的是同一个对象，单例模式保证了有且只有一个实例
            HungryMan hungryman1 = HungryMan.GetHungryMan();
            HungryMan hungryman2 = HungryMan.GetHungryMan();
            HungryMan hungryman3 = HungryMan.GetHungryMan();
            //打印输出哈希值说明指向的是同一个实例
            Console.WriteLine(hungryman1.GetHashCode());
            Console.WriteLine(hungryman2.GetHashCode());
            Console.WriteLine(hungryman3.GetHashCode());

            //LazyMan lazyman1 = LazyMan.GetLazyMan();
            //LazyMan lazyman2 = LazyMan.GetLazyMan();

            //Console.WriteLine(lazyman1.GetHashCode());
            //Console.WriteLine(lazyman2.GetHashCode());
            //可能会同时有几个线程进入创建实例的方法
            for (int i = 0; i < 10; i++)
            {
                new Thread(() => LazyMan.GetLazyMan()).Start();
            }

            //懒汉模式可能通过反射来破坏次单例模式
            
            //命名空间
            Type type = Type.GetType("SingleDesignModel");
            //类的名字
            //???
            var cons = type.GetConstructors(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //构造函数，非公开实例,类型强转
            var LazyMan1 = (LazyMan)cons[0].Invoke(null);
            var LazyMan2 = (LazyMan)cons[0].Invoke(null);
            Console.WriteLine(LazyMan1.GetHashCode());
            Console.WriteLine(LazyMan2.GetHashCode());

            for (int j = 0; j < 10; j++)
            {
                new Thread(() =>
                {
                    var sample = SampleLazyClass.GetLazyClass();
                    Console.WriteLine(sample.GetHashCode());
                }
                ).Start();

            }

            Console.ReadKey();
        }
    }
}
