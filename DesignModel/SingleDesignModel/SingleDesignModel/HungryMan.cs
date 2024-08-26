using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignModel
{
    public class HungryMan
    {
        //单例设计模式：饿汉模式
        //1.构造函数私有化
        //2.静态只读私有字段
        //3.静态公开的获取私有字段的方法
        
        private HungryMan() { }

        private static readonly HungryMan _hungryMan = new HungryMan();

        public static HungryMan GetHungryMan()
        {
            Console.WriteLine("I am a HungryMan!");
            return _hungryMan;
            
        }
    }
}
