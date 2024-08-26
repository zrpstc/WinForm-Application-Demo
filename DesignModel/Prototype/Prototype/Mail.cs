using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Mail:ICloneable
    {
        public string receiver { get; set; }//收件人
        public string subject { get; set; }//主题
        public string context { get; set; }//内容
        public string tail { get; set; }//尾部
        public string appellation { get; set; }//称谓

        public void SetMailInfo(AdvTemplate1 advTemplate1)
        {
            this.subject = advTemplate1.advSubject;
            this.context = advTemplate1.advContext;
            this.tail = advTemplate1.advTail;
        }

        public object Clone()
        {
            //返回对这个整个对象的克隆对象
            return this.MemberwiseClone();
        }
    }

    public class AdvTemplate1
    {
        public string advSubject { get; set; } = "默认主题";
        public string advContext { get; set; } = "学习学习";
        public string advTail { get; set; } = "to-zrp";
    }
}
