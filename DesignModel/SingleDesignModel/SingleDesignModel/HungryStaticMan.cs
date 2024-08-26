using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignModel
{
    //静态内部类方法实例化
    public class HungryStaticMan
    {
        //1.首先构造函数私有化，让外界无法创建实例
        private HungryStaticMan() { }

        //2.创建一个静态的内部类——用来创建对象
        public static class InnerClass
        {
            public static HungryStaticMan _HungryStaticMan = new HungryStaticMan();
        }

        //3.外界返回——不会随程序运行直接加载到内存，而是调用此方法时才开辟空间
        public static HungryStaticMan GetHungryStaticMan()
        {
            return InnerClass._HungryStaticMan;
        }
    }
}
