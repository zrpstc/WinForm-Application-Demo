using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace INI
{
    public class Class_INI
    {
        public string path;


        //public Class_INI(string INIPath)
        //{
        //    path = INIPath;
        //}

        public Class_INI()
        {

        }
        public Class_INI(string FileName)
        {
            path = Application.StartupPath + "\\" + FileName;
            //inipath = Application.StartupPath + "\\SaveSimpleCode.ini";
            //此方法也可通过：str = System.AppDomain.CurrentDomain.BaseDirectory + @"ConnectString.ini";
            //strOne = System.IO.Path.GetFileNameWithoutExtension(inipath);

        }

        public static string str = "";
        public static string strOne = "";
        #region 调用windowsAPI 1
        //初始化文件中指定的条目取得字串（输入参数）节名/（输入参数）键名/（输出参数）读取到的键值/（输入参数）lpReturnedString的缓冲区大小/（输入参数）INI文件的文件路径
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);
        [DllImport("kernel32")] //返回0表示失败，非0为成功 ,(输入参数）节名; （输入参数）需要写入的键值
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        #endregion
        #region 调用windowsAPI 2
        [DllImport("Kernel32.dll")]
        private static extern int GetPrivateProfileInt(string strAppName, string strKeyName, int nDefault, string strFileName);
        //获取ini文件所有的section
        [DllImport("Kernel32.dll")]
        private extern static int GetPrivateProfileSectionNamesA(byte[] buffer, int iLen, string fileName);
        //获取指定Section的key和value        
        [DllImport("Kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpReturnedString, int nSize, string lpFileName);
        //添加一个section内容列表
        [DllImport("Kernel32.dll")]
        public static extern long WritePrivateProfileSection(string strAppName, string strkeyandvalue, string strFileName);
        #endregion
        /// <summary>
        /// 读取文件返回字符串
        /// </summary>
        /// <param name="area"></param>
        /// <param name="key"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public string IniReadValue(string area, string key, string def)
        {
            if (File.Exists(path))
            {
                StringBuilder stringBuilder1 = new StringBuilder(1024); 				         //定义一个最大长度为1024的可变字符串
                int i = GetPrivateProfileString(System.IO.Path.GetFileNameWithoutExtension(area), key, def, stringBuilder1, 1024, path); 			//读取INI文件
                return stringBuilder1.ToString();//返回INI文件的内容
            }
            else
            {
                MessageBox.Show("未找到ini文件");
                using (FileStream fs = File.Create(path))
                {
                    //fs.Close();
                }
                return String.Empty;
            }

        }

        /// <summary>
        /// 判断文件是够存在，不存在则新建
        /// </summary>
        /// <param name="filePath"></param>
        public void FileExists(string filePath)
        {

            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                    fs.Close();
                }
            }

        }
        /// <summary>
        /// 返回该配置文件中所有Section名称的集合
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public ArrayList ReadAllSections()
        {
            byte[] buffer = new byte[65535];
            int rel = GetPrivateProfileSectionNamesA(buffer, buffer.GetUpperBound(0), path);
            int iCnt, iPos;
            ArrayList arrayList = new ArrayList();
            string tmp;
            if (rel > 0)
            {
                iCnt = 0; iPos = 0;
                for (iCnt = 0; iCnt < rel; iCnt++)
                {
                    if (buffer[iCnt] == 0x00)
                    {
                        tmp = System.Text.ASCIIEncoding.Default.GetString(buffer, iPos, iCnt - iPos).Trim();
                        iPos = iCnt + 1;
                        if (tmp != "")
                            arrayList.Add(tmp);
                    }
                }
            }
            return arrayList;
        }

        /// <summary>
        /// 读取指定节点下的指定key的value返回string
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public string GetIniKeyValueForStr(string section, string key)
        {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0) return string.Empty;
            StringBuilder strTemp = new StringBuilder(256);
            GetPrivateProfileString(section, key, string.Empty, strTemp, 256, path);
            return strTemp.ToString().Trim();
        }

        /// <summary>
        /// 往指定section的key中写入value
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteIniKey(string section, string key, string value)
        {
            if (File.Exists(path))
            {
                try
                {
                    if (WritePrivateProfileString(section, key, value, path) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("未找到路径文件");
                return false;
            }
        }
        /// <summary>
        /// 修改启动目录下指定section的key的值
        /// </summary>
        /// <param name="area"></param>
        /// <param name="code"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string inimathget(string area, string code, string filename)
        {
            string des = "";
            str = Application.StartupPath + "\\" + filename;				//INI文件的物理地址
            strOne = System.IO.Path.GetFileNameWithoutExtension(str); 		//获取INI文件的文件名
            if (File.Exists(str)) 											//判断是否存在该INI文件
            {
                des = IniReadValue(area, code, "");
                return des;
                //读取INI文件中用户节点的内容
            }
            else
            {
                MessageBox.Show("配置文件丢失");
                return null;
            }
        }

        /// <summary>
        /// 读取INI文件，返回byte[]
        /// </summary> 
        public byte[] IniReadValues(string section, string key)
        {
            byte[] temp = new byte[255];

            int i = GetPrivateProfileString(section, key, "", temp, 255, this.path);

            return temp;
        }

        /// <summary>
        /// 读取ini文件的所有段落名
        /// </summary>    
        public string[] IniReadAllSection()
        {
            byte[] allSection = IniReadValues(null, null);
            return ByteToString(allSection);

        }

        /// <summary>
        /// 转换byte[]类型为string[]数组类型 
        /// </summary>
        /// <param name="sectionByte"></param>
        /// <returns></returns>
        private string[] ByteToString(byte[] sectionByte)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            //编码所有key的string类型
            string sections = ascii.GetString(sectionByte);
            //获取key的数组
            string[] sectionList = sections.Split(new char[1] { '\0' });
            return sectionList;
        }

        /// <summary>
        /// 读取ini文件的某段落下所有键名
        /// </summary>    
        public string[] IniReadValues(string Section)
        {
            byte[] sectionByte = IniReadValues(Section, null);
            return ByteToString(sectionByte);
        }


        public static void AddToDatabase(string area, string code, string des, string filename)
        {
            str = Application.StartupPath + "\\" + filename;						//INI文件的物理地址
            if (File.Exists(str))											//判断是否存在INI文件
            {
                Class_INI.WritePrivateProfileString(area, code, des, str); 			//修改INI文件中用户节点的内容
            }
            else
            {
                MessageBox.Show("对不起，你所要修改的文件不存在，请确认后再进行修改操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// 读取启动目录下ini
        /// </summary>
        /// <param name="code"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string inimath(string code, string filename)
        {
            string des = "";
            str = Application.StartupPath + "\\" + filename;						//INI文件的物理地址
            strOne = System.IO.Path.GetFileNameWithoutExtension(str); 				//获取INI文件的文件名
            if (File.Exists(str)) 											//判断是否存在该INI文件
            {
                des = IniReadValue(Class_INI.strOne, code, "");
                return des;
                //读取INI文件中用户节点的内容
            }
            else
            {
                MessageBox.Show("配置文件丢失");
                return null;
            }
        }

    }
}
