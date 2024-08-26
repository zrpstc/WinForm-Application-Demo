using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignModel
{
    public class SampleLazyClass
    {
        private SampleLazyClass() { }

        //创建一个只读的字段
        private static readonly Lazy<SampleLazyClass> Lazy = new Lazy<SampleLazyClass>(() => new SampleLazyClass());

        public static SampleLazyClass GetLazyClass()
        {
            return Lazy.Value;
        }

    }
}
