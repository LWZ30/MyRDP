using MSTSCLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyRDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (btn_conn.Text == "连接")
            {
                if (tb_server.Text == "")
                {
                    MessageBox.Show("请输入主机地址");
                    return;
                }
                if (tb_user.Text == "")
                {
                    MessageBox.Show("请输入用户名");
                    return;
                }
                if (tb_pwd.Text == "")
                {
                    MessageBox.Show("请输入密码");
                    return;
                }
                try
                {
                    rdp.Server = tb_server.Text;
                    rdp.UserName = tb_user.Text;
                    IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
                    secured.ClearTextPassword = tb_pwd.Text;
                    rdp.Connect();
                    btn_conn.Text = "断开连接";
                    btn_conn.BackColor = Color.Red;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("无法链接远程主机" + Ex.Message);
                    return;
                }
            }
            else
            {
                btn_conn.Text = "连接";
                btn_conn.BackColor = Color.PaleGreen;
                try
                {
                    rdp.Disconnect();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("断开连接失败" + Ex.Message);
                    return;
                }
                rdp.Refresh();
            }
        }
    }
}
