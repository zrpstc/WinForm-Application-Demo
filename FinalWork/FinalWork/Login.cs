using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using INI;


namespace FinalWork
{
    //1.申明委托，传递登录的用户名参数
    public delegate void LoginUserToManage(string username, string password, int power);
    public partial class Login : Form
    {
        //2.定义事件
        public event LoginUserToManage lutm_event;

        Class_INI ini = new Class_INI("AccountPassword");
        SqlCon MyConn = new SqlCon();
        User user = new User();
        SqlParameter[] paras =
        {
            new SqlParameter("@name", SqlDbType.VarChar, 50),
            new SqlParameter("@password", SqlDbType.VarChar, 50),
            new SqlParameter("@power", SqlDbType.Int),
        };


        public Login()
        {
            InitializeComponent();
        }

        public void get_value()
        {
            user.Name = textBoxname.Text;
            user.Password = textBoxpassword.Text;
            if(checkBoxPower.Checked)
            {
                //管理员用户
                user.Power = 0;
            }
            else
            {
                //普通用户
                user.Power = 1;
            }

            paras[0].Value = user.Name;
            paras[1].Value = user.Password;
            paras[2].Value = user.Power;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            get_value();
            try
            {
                if (MyConn.ExecSql("sysuser_select", paras) > 0)
                {
                    //记住密码保存到ini配置文件
                    if (cb_RemPass.Checked)
                    {
                        ini.FileExists(ini.path);
                        ini.WriteIniKey("user", user.Name, user.Password);
                    }

                    MessageBox.Show("跳转到预订系统！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Manage manage = new Manage();
                    //5.关联事件
                    lutm_event += new LoginUserToManage(manage.SaveInfoToUser);


                    //3.激发事件---传递参数给主界面
                    lutm_event(user.Name, user.Password, user.Power);
                    manage.Show();
                    this.Hide();

                    if (cb_AutoLogin.Checked)
                    {
                        cb_RemPass.Checked = true;
                        ini.FileExists(ini.path);
                        ini.WriteIniKey("autoLogin", "sp_user", user.Name);
                    }
                    else
                    {
                        ini.FileExists(ini.path);
                        ini.WriteIniKey("autoLogin", "sp_user", null);
                    }
                }
                else
                {
                    MessageBox.Show("请确认用户名密码或权限是否正确！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MyConn.con_close();
            }

        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            get_value();
            try
            {
                //SQLServe中编写存储过程插入用户 sysuser_inert
                if (MyConn.ExecSql("sysuser_insert",paras) > 0)
                {
                    MessageBox.Show("注册成功！请输入账号密码登录！", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户名已被注册！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
            finally
            {
                MyConn.con_close();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            string name = ini.GetIniKeyValueForStr("autoLogin", "sp_user");
            if (name != "")
            {
                Manage manage = new Manage();
                //5.关联事件
                lutm_event += new LoginUserToManage(manage.SaveInfoToUser);
                //3.激发事件---传递参数给主界面
                lutm_event(name, "", user.Power);
                this.Hide();
                manage.Show();
            }
        }
    }
}
