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


namespace checkwork_week5
{
    public partial class Login : Form
    {
        ////定义委托，传递选择自动登录的用户名参数
        //public delegate void AutoLoginUserName(string str);
        ////实例化委托对象
        //public event AutoLoginUserName autologin_event;

        Class_INI ini = new Class_INI("AccountPassword");
        SqlCon MyConn = new SqlCon();
        User user = new User();
        SqlParameter[] paras =
        {
            new SqlParameter("@name", SqlDbType.VarChar, 50),
            new SqlParameter("@password", SqlDbType.VarChar, 50),
            new SqlParameter("@username", SqlDbType.VarChar, 50),
            new SqlParameter("@note", SqlDbType.VarChar, 50),
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
                user.Power = 0;
            }
            else
            {
                user.Power = 1;
            }

            paras[0].Value = user.Name;
            paras[1].Value = user.Password;
            paras[2].Value = "";
            paras[3].Value = "";
            paras[4].Value = user.Power;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            SqlParameter[] paras1 =
            {
                new SqlParameter("@name", SqlDbType.VarChar, 50),
                new SqlParameter("@password", SqlDbType.VarChar, 50),
            };
            user.Name = textBoxname.Text;
            user.Password = textBoxpassword.Text;
            if (checkBoxPower.Checked)
            {
                user.Power = 0;
            }
            else
            {
                user.Power = 1;
            }
            paras1[0].Value = user.Name;
            paras1[1].Value = user.Password;

            try
            {
                if (MyConn.ExecSql("user_select", paras1) > 0)
                {
                    //记住密码保存到ini配置文件
                    if (cb_RemPass.Checked)
                    {
                        ini.FileExists(ini.path);
                        ini.WriteIniKey("user", user.Name, user.Password);
                    }
                    //管理员用户
                    if(user.Power == 0)
                    {
                        MessageBox.Show("登录成功！");
                        Manage manage = new Manage();
                        manage.Show();
                        this.Hide();
                    }
                    //普通用户访客
                    else if(user.Power == 1)
                    {
                        MessageBox.Show("登录成功！");
                        //Visit visit = new Visit();
                        //visit.Show();
                        this.Hide();
                    }

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
                    MessageBox.Show("登陆失败！ 请确认用户名或密码是否正确！");
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
                //SQLServe中编写存储过程插入用户 user_inert
                if (MyConn.ExecSql("user_insert",paras) > 0)
                {
                    MessageBox.Show("注册成功！");
                }
                else
                {
                    MessageBox.Show("用户名已被注册！");
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
                this.Hide();
                manage.Show();
            }
        }
    }
}
