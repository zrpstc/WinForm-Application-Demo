using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace checkwork_week4
{
    public partial class Serve : Form
    {
        public Serve()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 监听连接请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建用于监听的socket
            Socket socketwatch = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBox1.Text));

            //监听
            socketwatch.Bind(point);
            socketwatch.Listen(10);
            showmsg("监听成功");

            //开辟新线程一直监听客户端的连接
            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketwatch);
        }
        //10.76.17.95

        /// <summary>
        /// 开辟新的线程一直监听客户端的连接
        /// </summary>
        Socket socketsend;
        void Listen(object o)
        {
            Socket socketwatch = o as Socket;
            while (true)
            {
                //等待客户端的连接，并创建一个用于通信的socket
                socketsend = socketwatch.Accept();
                showmsg(socketsend.RemoteEndPoint.ToString() + ": 连接成功");

                //开辟新的后台线程一直接收客户端发来的消息
                Thread th = new Thread(receive);
                th.IsBackground = true;
                th.Start(socketsend);
            }
        }

        //定义键值对将ip和对应的通讯socket存入
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 接收客户端发来的消息
        /// </summary>
        /// <param name="o"></param>
        public void receive(object o)  //线程中传递变量必须是object类型
        {
            Socket socketsend = o as Socket;

            //将连接的ip和对应的socket存入键值对
            dicSocket.Add(socketsend.RemoteEndPoint.ToString(), socketsend);

            //将连接的ip和端口号存入combox中
            comboBox1.Items.Add(socketsend.RemoteEndPoint.ToString());
            while (true)
            {
                try
                {
                    //接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int i = socketsend.Receive(buffer);

                    //断开连接时接收到的数据长度为0，此时跳出循环
                    if (i == 0)
                    {
                        comboBox1.Items.Remove(socketsend.RemoteEndPoint.ToString());
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, i);
                    showmsg(socketsend.RemoteEndPoint + ":" + str);
                }
                catch { }
            }
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="s"></param>
        void showmsg(string s)
        {
            textBox2.AppendText(s + "\r\n");
        }
    }
}
