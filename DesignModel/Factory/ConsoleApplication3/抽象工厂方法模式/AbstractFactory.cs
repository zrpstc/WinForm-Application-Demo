using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFactory.简单工厂;

namespace SampleFactory.抽象工厂方法模式
{
    public abstract class AbstractFactory
    {
        public abstract T CreatHuman<T>()where T:class,IHuman;

        //两个抽象方法——创造人类和  创造宠物两个技能
        public abstract T CreatPet<T>() where T : class, IPet;
    }

    public class Factory : AbstractFactory
    {
        public override T CreatHuman<T>()
        {
            try
            {
                var human = Activator.CreateInstance(typeof(T)) as T;
                return human;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public override T CreatPet<T>()
        {
            try
            {
                var pet = Activator.CreateInstance(typeof(T)) as T;
                return pet;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }

}
