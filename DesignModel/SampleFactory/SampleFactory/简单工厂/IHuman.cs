using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//简单工厂模式
namespace SampleFactory
{
    //创建人类的接口
    public interface IHuman
    {
        void GetColor();
        void Talk();
    }

    public class YellowHuman:IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("yellow");
        }
        public void Talk()
        {
            Console.WriteLine("yellow talk");
            
        }
        
    }

    public class WhiteHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("white");
        }
        public void Talk()
        {
            Console.WriteLine("white talk");
        }

    }

    public class BlackHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("black");
        }
        public void Talk()
        {
            Console.WriteLine("black talk");
        }

    }
}
