using SampleFactory.工厂方法设计模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//简单工厂模式
namespace SampleFactory.简单工厂
{
    //创建人类的接口
    public interface IHuman
    {
        void GetColor();
        void Talk();
    }

    [TypeNameToInstance("yellow")]
    public class YellowHuman:IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("yellowhuman");
        }
        public void Talk()
        {
            Console.WriteLine("yellowh talk");
            
        }
        
    }

    public class WhiteHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("whitehuman");
        }
        public void Talk()
        {
            Console.WriteLine("whiteh talk");
        }

    }

    public class BlackHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("blackhuman");
        }
        public void Talk()
        {
            Console.WriteLine("blackh talk");
        }

    }
}
