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
using Log.Utils;


namespace checkwork_week4_Serve
{
    public partial class Serve : NForm
    {
        //申明委托类
        public delegate void LoadData(DataTable dt);
        public delegate void DeleteData();

        //定义委托方法
        public void DoLoad(object dt)
        {
            this.Invoke((LoadData)load, new Object[] { dt });
        }

        public void load(DataTable dt)
        {
            this.dataGridViewExcel.DataSource = dt;
        }

        public void DoDelete()
        {
            this.Invoke((DeleteData)delete, new Object[] { });
        }

        public void delete()
        {
            DataTable dt = (DataTable)dataGridViewExcel.DataSource;
            dt.Rows.Clear();
            dataGridViewExcel.DataSource = dt;
        }

        ExcelToDGV exceltodgv = new ExcelToDGV();
        Logger logger = new Logger();

        //服务器监听Socket
        Socket socketwatch;
        //服务器通信Socket
        Socket socketsend;

        //创建监听连接的线程
        Thread AcceptSocketThread;
        //创建接收客户端所发送消息的线程
        Thread AcceptMessageThread;

        //定义键值对将ip和对应的通讯socket存入
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        //定义目前连接的客户端数量
        int num;

        public Serve()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
            //取消跨线程检查
            Control.CheckForIllegalCrossThreadCalls = false;
            toolStripStatusLabelConNum.Text = "已连接的客户端数：0";
        }

        public void Serve_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开辟新的线程一直监听客户端的连接
        /// </summary>
        void Listen(object o)
        {
            //强制类型转换
            Socket socketwatch = o as Socket;
            while (true)
            {
                //等待客户端的连接，并创建一个用于通信的socket
                socketsend = socketwatch.Accept();
                ShowMessage3(DateTime.Now + "  " + socketsend.RemoteEndPoint.ToString() + ": 客户端连接成功!");
                //报错：线程间操作无效，从不是创建控件的线程访问它（上面监听连接的新线程）

                //开辟新的后台线程一直接收客户端发来的消息
                AcceptMessageThread = new Thread(ReceiveMessage);
                AcceptMessageThread.IsBackground = true;
                AcceptMessageThread.Start(socketsend);

                if (dicSocket != null)
                {
                    buttonStopWatch.Enabled = false;
                }
            }
        }


        /// <summary>
        /// 接收客户端发来的消息
        /// </summary>
        /// <param name="o"></param>
        public void ReceiveMessage(object o)  //线程中传递变量必须是object类型
        {
            Socket socketsend = o as Socket;

            //将连接的ip和对应的socket存入键值对
            dicSocket.Add(socketsend.RemoteEndPoint.ToString(), socketsend);

            //将连接的ip和端口号存入combox中
            comboBoxConList.Items.Add(socketsend.RemoteEndPoint.ToString());
            num = comboBoxConList.Items.Count - 1;
            toolStripStatusLabelConNum.Text = "已连接的客户端数："+ num;
            while (true)
            {
                
                if (socketsend.Poll(-1, SelectMode.SelectRead))
                {
                    try
                    {
                        //监听线程休眠
                        Thread.Sleep(10);
                        //接收客户端发来的消息
                        //字符流长度为2M
                        byte[] buffer = new byte[1024 * 1024 * 2];
                        //实际接收到的有效字节数
                        int i = socketsend.Receive(buffer);
                        //获取标志位判断操作的类型
                        int n = buffer[0];
                        //实际接收到的消息字符或路径
                        string str = "";
                        str = Encoding.UTF8.GetString(buffer, 1, i-1);

                        //客户端关闭 接收到的数据长度为0，此时跳出循环
                        if (i == 0)
                        {
                            //回应客户端，向客户端发送消息
                            //将机器的编码转换成人能识别的字符
                            byte[] endbuffer = Encoding.UTF8.GetBytes("End");
                            socketsend.Send(endbuffer);
                            //Console.WriteLine("连接正常断开！");
                            break;
                        }
                        //增加处理所接收信息的逻辑

                        //删除日志
                        //if (str == "DeleteLog")
                        if (n == 1)
                        {
                            logger.DeleteLog();
                            //ShowMessage3("日志文件已删除");
                            byte[] endbuffer = Encoding.UTF8.GetBytes("日志文件已删除");
                            socketsend.Send(endbuffer);
                        }
                        //加载数据
                        if (n == 2)
                        {
                            DataTable showdt = exceltodgv.ExcelToDataTable(str);

                            DoLoad(showdt);
                            //Thread thread = new Thread(DoLoad);
                            //传递参数
                            //thread.Start(showdt);
                            //pictureBox1.Image = Image.FromFile("D:\\visual studio 2015\\Projects\\checkwork - week4 - Serve\\checkwork - week4 - Serve\\wait.gif");
                            //直接使用线程操作别的线程控件会卡死
                            //dataGridViewExcel.DataSource = showdt;
                            
                            byte[] endbuffer = Encoding.UTF8.GetBytes("数据已加载");
                            socketsend.Send(endbuffer);
                        }
                        //删除数据
                        if (n == 3)
                        {
                            //存在的问题：跨线程调用主线程的控件会使界面卡死
                            //清除DGV数据
                            //DataTable dt = (DataTable)dataGridViewExcel.DataSource;
                            //dt.Rows.Clear();
                            //dataGridViewExcel.DataSource = dt;

                            
                            Thread thread = new Thread(DoDelete);
                            //传递参数
                            thread.Start();

                            byte[] endbuffer = Encoding.UTF8.GetBytes("数据已删除");
                            socketsend.Send(endbuffer);
                        }
                        if (n == 0)
                        {
                            //打印客户端消息
                            ShowMessage(DateTime.Now + "  " + socketsend.RemoteEndPoint.ToString() + ":" + str);

                        }
                    }
                    catch
                    {
                        if(dicSocket == null)
                            buttonStopWatch.Enabled = true;
                        //ShowMessage("连接异常断开！");
                        ShowMessage3(DateTime.Now + "  "+socketsend.RemoteEndPoint.ToString() + ":" + "客户端已下线！");

                        comboBoxConList.Items.Remove(socketsend.RemoteEndPoint.ToString());
                        num = comboBoxConList.Items.Count - 1;
                        toolStripStatusLabelConNum.Text = "已连接的客户端数：" + num;
                        //断开连接则退出循环，停止监听
                        break;
                    }
                }
                else
                {
                    //监听线程休眠防止客户端断连后不停刷新卡顿
                    Thread.Sleep(1000);
                }
            }
        }


        public delegate void showmess(string s);

        /// <summary>
        /// 显示接收到客户端的信息
        /// </summary>
        /// <param name="s"></param>
        public void ShowMessage(string s)
        {
            this.textBoxReceMess.Text += s + "\r\n\n";
            //textBox5.AppendText(s + "\r\n");

            //InvokeReuired需要比较调用线程ID和创建线程ID
            //如果不相同返回true
            //if (this.textBox1.InvokeRequired)
            //{
            //    showmess show = new showmess(ShowMessage);
            //    this.Invoke(show, new object[] { s });
            //}
            //else
            //{
            //    this.textBox5.Text += s + "\r\n";
            //}
        }
       
        /// <summary>
        /// 提示和日志消息
        /// </summary>
        /// <param name="s"></param>
        public void ShowMessage3(string s)
        {
            textBoxLog.AppendText(s + "\r\n\n");
            logger.WriteLog(s + "\r\n");
        }

        /// <summary>
        /// 监听连接请求
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartWatch_Click(object sender, EventArgs e)
        {
            //创建用于监听的socket
            socketwatch = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBoxPort.Text));

            try
            {
                //套接字绑定端口号和IP地址并监听
                socketwatch.Bind(point);
                socketwatch.Listen(10);
                ShowMessage3("监听成功");

                //开辟新线程一直监听客户端的连接
                AcceptSocketThread = new Thread(Listen);
                AcceptSocketThread.IsBackground = true;
                AcceptSocketThread.Start(socketwatch);
            }
            catch
            {

            }
        }

        /// <summary>
        /// 停止监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopWatch_Click(object sender, EventArgs e)
        {
            try
            {
                //终止Socket
                if (socketsend != null)
                    socketsend.Close();
                if (socketwatch != null)
                    socketwatch.Close();

                //终止线程
                if (AcceptSocketThread != null)
                {
                    AcceptSocketThread.Abort();
                }
                if (AcceptMessageThread != null)
                {
                    AcceptMessageThread.Abort();
                }


                ShowMessage3("停止监听,客户端断开连接!");
            }
            catch
            {

            }
        }

        /// <summary>
        /// 发送信息按钮
        /// 选择客户并向其发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            string s = textBoxSendMess.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(s);
            try
            {
                //增加向所有客户端广播逻辑
                if (comboBoxConList.SelectedItem.ToString() == "ALL")
                {
                    for (int i = 1; i < comboBoxConList.Items.Count; i++)
                    {
                        string strClientKey = comboBoxConList.GetItemText(comboBoxConList.Items[i]);
                        dicSocket[strClientKey].Send(buffer);
                    }
                }
                else
                {
                    //没有选择ALL则向选中的客户端发送数据
                    dicSocket[comboBoxConList.SelectedItem.ToString()].Send(buffer);
                }
            }
            catch
            {
                ShowMessage3("请选择要通信的客户端！");
            }
        }
    }
}
