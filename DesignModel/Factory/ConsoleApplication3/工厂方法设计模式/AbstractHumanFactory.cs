using SampleFactory.简单工厂;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.工厂方法设计模式
{
    public abstract class AbstractHumanFactory
    {
        public abstract T CreatHuman<T>() where T : class, IHuman;
    }

    //可以定义不同的工厂类供不同的对象来使用，这样一个坏了其他还能继续使用
    //优点是封装性特别好，将原来在program中使用creatHuman转移到了一个定义好的方法中
    //不论是简单工厂还是工厂方法都是延迟对象的创建，把原来在客户端创建转移到方法中
    public class HumanFactory : AbstractHumanFactory
    {
        public override T CreatHuman<T>()
        {
            try
            {
                var human = Activator.CreateInstance(typeof(T)) as T;
                return human;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }


    //实现通过字符串实现简单工厂模式
    //1.写一个特性（狗皮膏药）
    public class TypeNameToInstance : Attribute
    {
        public string TypeName { get; }

        public TypeNameToInstance(string s)
        {
            this.TypeName = s;
        }
    }


    //2.编写工厂延迟加载
    public class FactoryDelay
    {
        //编写一个字典
        public static Dictionary<string, IHuman> dic = new Dictionary<string, IHuman>();
        //根据string字符串s获得IHuman类型
        public IHuman GetHuman(string TypeName)
        {
            if (dic.ContainsKey(TypeName))
            {
                return dic[TypeName];
            }
            return null;
        }

        public FactoryDelay()
        {
            //1.获取正在运行的程序集并获取所有类型（里面包含了三大人种类型）
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (var item in assembly.GetTypes())
            {
                //2.对这个item进行一个判断，判断是否实现了IHuman的接口，并且不是Ihuman本身
                if (typeof(IHuman).IsAssignableFrom(item) && !item.IsInterface)
                {
                    //3.获取item上面特性的名字属性
                    var TypeNameToInstance = item.GetCustomAttribute<TypeNameToInstance>();
                    //判断
                    if (!string.IsNullOrEmpty(TypeNameToInstance.TypeName))
                    {
                        //绑定类型的key和value
                        dic[TypeNameToInstance.TypeName] = Activator.CreateInstance(item) as IHuman;
                    }
                }
            }
        }
    }


    

}
