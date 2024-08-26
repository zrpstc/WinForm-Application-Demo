using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Utils
{
    public class Logger
    {
        DateTime dt = DateTime.Now;
        static string path = "D:/Log_Client/";

        /// <summary>
        /// 构造函数执行创建Log文件的动作
        /// </summary>
        public Logger()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }
        }

        /// <summary>
        /// 保存日志到文件
        /// </summary>
        /// <param name="info">日志信息</param>
        public void WriteLog(string info)
        {
            //生成的日志的文件名
            string filename = dt.ToString("yyyyMMdd") + "_log.txt";
            //string path = System.AppDomain.CurrentDomain.BaseDirectory;

            FileStream fs;
            if (!File.Exists(path + filename))
            {
                fs = new FileStream(path + filename, FileMode.Create, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(path + filename, FileMode.Open, FileAccess.Write);
            }
            StreamWriter sw = new StreamWriter(fs);
            long fl = fs.Length;
            fs.Seek(fl, SeekOrigin.Begin);
            sw.WriteLine(DateTime.Now.ToString() + "_S:________  " + info + "  __________End.\n");
            sw.Close();
            fs.Close();
        }


        /// <summary>
        /// 获取日志文件保存的信息
        /// </summary>
        /// <param name="path">日志文件路径</param>
        /// <returns></returns>
        public string GetLogText(string path)
        {
            string text = "";
            if (!File.Exists(path))
            {
                text = "没有找到日志文件！";
            }
            else
            {
                //用指定的字符编码为指定的文件名初始化 StreamReader 类的一个新实例
                StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8);
                //从流的当前位置到末尾读取所有字符
                String input = sr.ReadToEnd();
                sr.Close();
                text = input;
            }
            return text;
        }

    }

}
