using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Thing : ICloneable
    {
        private Student student = new Student();

        public void SetValue(string value)
        {
            student.Name = value;
        }

        public string GetValue()
        {
            return student.Name;
        }

        public object Clone()
        {
            //深拷贝特殊处理
            Thing thing = null;
            thing = (Thing)this.MemberwiseClone();
            thing.student = (Student)this.student.Clone();
            return thing;
            //

            //深浅复制的不同之处在于对于class类型的student，浅拷贝是是直接复制原student的引用，即指向同一块内存空间
            //而深拷贝是全新复制一个student对象，开辟了自己的内存空间
            //return this.MemberwiseClone();
        }
    }
    
    //浅拷贝改造——深拷贝：也实现ICloneable接口
    public class Student:ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
