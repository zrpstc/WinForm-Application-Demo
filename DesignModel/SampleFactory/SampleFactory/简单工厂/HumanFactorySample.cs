using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactory.简单工厂
{
    public class HumanFactorySample
    {
        //炼丹炉的静态方法
        public static T CreatHuman<T>()where T : class, IHuman
        {
            IHuman human = null;
            //通过反射来生成一个human泛型类型的实例
            try
            {
                human = Activator.CreateInstance<T>() as IHuman;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return human as T;
        }
    }
}
