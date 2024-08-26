using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingleDesignModel
{
    class LazyMan
    {
        //单例设计模式：懒汉模式
        //1.构造函数私有化
        //为了避免反射注入，我们引入标志位
        private static bool isReflection = true;


        private LazyMan()
        {
            lock (o)
            {
                if (isReflection)
                {
                    isReflection = false;

                }
                else
                {
                    throw new Exception("不可以从外界创建");
                }
            }
        }
        //2.写一个私有的字段
        //关键字voatile避免指针重排
        private static volatile LazyMan _lazyMan;

        //3.写一个方法暴露给外界这个实例
        //缺点：这里线程不安全  加锁机制
        private static object o = new object();
        public static LazyMan GetLazyMan()
        {
            //lock是一个互斥锁，是c#封装的语法糖包括Monitor.Enter()  Monitor.Exit()
            if(_lazyMan == null)//降低竞争锁的资源消耗
            {
                lock (o)
                {
                    if (_lazyMan == null)
                    {
                        //new LazyMan()
                        //1.开辟一块内存空间
                        //2.创建一个对象
                        //3.将对象指向内存空间
                        //正常执行顺序123 有时变成132。称为指针重排
                        _lazyMan = new LazyMan();
                        Console.WriteLine($"Current Threading is {Thread.CurrentThread.ManagedThreadId}");
                    }
                    
                }
            }

            return _lazyMan;
        }
    }
}
