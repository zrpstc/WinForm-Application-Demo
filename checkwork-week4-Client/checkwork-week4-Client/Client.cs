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
using Log.Utils;

namespace checkwork_week4_Client
{
    public partial class Client : Form
    {
        Logger logger = new Logger();

        //定义管理连接的全局变量Socket
        Socket socketsend;
        //接收服务器数据的线程
        Thread AcceptMessageThread;

        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
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
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int i = socketsend.Receive(buffer);
                    //断开连接则字符流长度为0
                    if(i == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, i);
                    ShowMessage(DateTime.Now + "  " + socketsend.RemoteEndPoint.ToString() + ":" + str);
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
            textBoxReceive.AppendText(msg + "\r\n\n");
            logger.WriteLog(msg + "\r\n");
        }

        private void buttonConn_Click(object sender, EventArgs e)
        {
            try
            {
                //使用Socket构造函数实例化一个Socket对象，用来连接远程主机
                //数据传输方式有两种，Stream传输是可靠的传输，而Dgram是高效传输但不一定可靠
                socketsend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(textBoxAddress.Text);
                //使用指定的IP地址和端口号实例化IPEndPoint对象
                IPEndPoint port = new IPEndPoint(ip, Convert.ToInt32(textBoxPort.Text));

                //连接对应端口
                //此行代码的连接方式没有超时时间设置，无法连上服务器时会卡顿20-30s
                //socketsend.Connect(port);
                //于是采用异步方式进行连接的远程服务器的IP地址和端口号
                IAsyncResult result = socketsend.BeginConnect(port, null, null);
                var success = result.AsyncWaitHandle.WaitOne(500);
                if (success)
                {
                    ShowMessage(DateTime.Now + "  " + socketsend.RemoteEndPoint.ToString() + ": 服务器连接成功!");
                    buttonConn.Enabled = false;
                }
                else
                {
                    ShowMessage(port.ToString() + ": 服务器连接失败!");
                }


                //开辟接收服务器数据的线程
                AcceptMessageThread = new Thread(ReceiveMessage);
                //后台线程
                AcceptMessageThread.IsBackground = true;
                //启动连接
                AcceptMessageThread.Start();

                
            }
            catch
            {

            }
        }

        private void buttonDisConn_Click(object sender, EventArgs e)
        {
            if (socketsend != null)
            {
                socketsend.Close();
            }
            if (AcceptMessageThread != null)
            {
                AcceptMessageThread.Abort();
            }
            ShowMessage("已断开与服务器的连接!");
            buttonConn.Enabled = true;

        }

        private void buttonSendMess_Click(object sender, EventArgs e)
        {
            try
            {
                string str = textBoxSend.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                //创建泛型集合存放字节数组
                List<byte> list = new List<byte>();
                //集合第一位添加类型：0-文字消息，1-删除日志，2-上传数据，3-删除数据
                list.Add(0);
                //加入原有发送内容
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                socketsend.Send(newbuffer);
            }
            catch
            {
                ShowMessage("服务器已断开连接，无法发送信息！");
            }
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024 * 1024 * 2];
            //创建泛型集合存放字节数组
            List<byte> list = new List<byte>();
            list.Add(1);
            byte[] newbuffer = list.ToArray();
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes("DeleteLog");
            try
            {
                socketsend.Send(newbuffer);
            }
            catch
            {
                ShowMessage("服务器已强制断开连接！");
            }
        }

        private void buttonDownData_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开要加载的数据文件";
            openFileDialog.Filter = "Excel 文件(*.xls)|*.xls|Excel 文件(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //filepath = System.IO.Path.GetFullPath(openFileDialog.FileName);
                filepath = openFileDialog.FileName;
            }
            byte[] path = System.Text.Encoding.UTF8.GetBytes(filepath);
            //byte[] buffer = new byte[1024 * 1024 * 2];
            List<byte> list = new List<byte>();
            list.Add(2);
            list.AddRange(path);
            byte[] newbuffer = list.ToArray();
            try
            {
                socketsend.Send(newbuffer);
            }
            catch
            {
                ShowMessage("服务器已强制断开连接！");
            }

            //合并字节数组
            //byte[] sendbuffer = newbuffer.Concat(path).ToArray();
            //byte[] sendbuffer = new byte[path.Length + newbuffer.Length];
            //Array.Copy(newbuffer, 0, sendbuffer, 0, newbuffer.Length);
            //Array.Copy(path, 0, sendbuffer, newbuffer.Length, path.Length);
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes("DonloadData");
            //socketsend.Send(sendbuffer);
            //MessageBox.Show(Encoding.UTF8.GetString(sendbuffer));
        }

        private void buttonDeleData_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024 * 1024 * 2];
            List<byte> list = new List<byte>();
            list.Add(3);
            byte[] newbuffer = list.ToArray();
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes("DeleteData");
            try
            {
                socketsend.Send(newbuffer);
            }
            catch
            {
                ShowMessage("服务器已强制断开连接！");
            }
            
        }
    }
}
