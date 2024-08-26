using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INI;

namespace checkwork_week5
{
    public partial class Manage : NForm
    {
        Class_INI ini = new Class_INI("AccountPassword");
        public Manage()
        {
            InitializeComponent();
            GetAllInitInfo(this.Controls[0]);
        }

        private void bReLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login relogin = new Login();
            relogin.Show();

            ini.FileExists(ini.path);
            ini.WriteIniKey("autoLogin", "sp_user", null);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Index == 1)
            {
                BookForm bookform = new BookForm();
                bookform.Show();
                bookform.TopMost = true;
            }

        }
    }
}
