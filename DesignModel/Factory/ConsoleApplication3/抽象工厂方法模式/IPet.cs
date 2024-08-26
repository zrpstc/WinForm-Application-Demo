using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.抽象工厂方法模式
{
    public interface IPet
    {
        void GetColor();
        void Talk();
    }

    public class YellowPet : IPet
    {
        public void GetColor()
        {
            Console.WriteLine("yellowpet");
        }
        public void Talk()
        {
            Console.WriteLine("yellowp talk");

        }

    }

    public class WhitePet : IPet
    {
        public void GetColor()
        {
            Console.WriteLine("whitepet");
        }
        public void Talk()
        {
            Console.WriteLine("whitep talk");
        }

    }

    public class BlackPet : IPet
    {
        public void GetColor()
        {
            Console.WriteLine("blackpet");
        }
        public void Talk()
        {
            Console.WriteLine("blackp talk");
        }

    }
}
