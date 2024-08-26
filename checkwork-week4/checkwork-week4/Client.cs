using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkwork_week4
{
    public partial class Client : Form
    {
        //定义管理连接的全局变量Socket
        Socket socketsend;
        public Client()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 客户端与服务端建立连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //使用Socket构造函数实例化一个Socket对象，用来连接远程主机
                socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(textBox1.Text);
                //使用指定的IP地址和端口号实例化IPEndPoint对象
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(textBox2.Text));

                //连接对应端口
                socketsend.Connect(port);
                ShowMessage(socketsend.RemoteEndPoint + ": 连接成功!");

                //开辟接收服务器数据的线程
                Thread th = new Thread(ReceiveMessage);
                //后台线程
                th.IsBackground = true;
                th.Start();
            }
            catch
            {

            }
        }

        /// <summary>
        /// 接收服务器反馈的信息
        /// </summary>
        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[256];
                    int i = socketsend.Receive(buffer);

                    if(i == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, i);
                    ShowMessage(socketsend.RemoteEndPoint + ":" + str);
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="msg"></param>
        public void ShowMessage(string msg)
        {
            textBox3.AppendText(msg + "\r\n");
        }
    }
}
