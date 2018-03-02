namespace MyRDP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_conn = new System.Windows.Forms.Button();
            this.rdp = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "主机";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "端口";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(66, 532);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(100, 21);
            this.tb_server.TabIndex = 5;
            this.tb_server.Text = "192.168.4.100";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(221, 532);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 21);
            this.tb_user.TabIndex = 6;
            this.tb_user.Text = "administrator";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(364, 532);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(100, 21);
            this.tb_pwd.TabIndex = 7;
            this.tb_pwd.Text = "cladding$DOORS";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(507, 532);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "3389";
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(675, 531);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(75, 23);
            this.btn_conn.TabIndex = 9;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // rdp
            // 
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(0, 0);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(784, 515);
            this.rdp.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_conn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsTscAxNotSafeForScripting rdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_conn;
    }
}

