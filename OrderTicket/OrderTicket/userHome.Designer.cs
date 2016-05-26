namespace OrderTicket
{
    partial class UserHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.列车信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改登录密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列车信息查询ToolStripMenuItem,
            this.购票ToolStripMenuItem,
            this.查看用户信息ToolStripMenuItem,
            this.查看订单ToolStripMenuItem,
            this.修改登录密码ToolStripMenuItem,
            this.返回ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 列车信息查询ToolStripMenuItem
            // 
            this.列车信息查询ToolStripMenuItem.Name = "列车信息查询ToolStripMenuItem";
            this.列车信息查询ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.列车信息查询ToolStripMenuItem.Text = "列车信息查询";
            this.列车信息查询ToolStripMenuItem.Click += new System.EventHandler(this.列车信息查询ToolStripMenuItem_Click);
            // 
            // 购票ToolStripMenuItem
            // 
            this.购票ToolStripMenuItem.Name = "购票ToolStripMenuItem";
            this.购票ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.购票ToolStripMenuItem.Text = "购票";
            this.购票ToolStripMenuItem.Click += new System.EventHandler(this.购票ToolStripMenuItem_Click);
            // 
            // 查看用户信息ToolStripMenuItem
            // 
            this.查看用户信息ToolStripMenuItem.Name = "查看用户信息ToolStripMenuItem";
            this.查看用户信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.查看用户信息ToolStripMenuItem.Text = "查看用户信息";
            this.查看用户信息ToolStripMenuItem.Click += new System.EventHandler(this.查看用户信息ToolStripMenuItem_Click);
            // 
            // 查看订单ToolStripMenuItem
            // 
            this.查看订单ToolStripMenuItem.Name = "查看订单ToolStripMenuItem";
            this.查看订单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查看订单ToolStripMenuItem.Text = "查看订单";
            this.查看订单ToolStripMenuItem.Click += new System.EventHandler(this.查看订单ToolStripMenuItem_Click);
            // 
            // 修改登录密码ToolStripMenuItem
            // 
            this.修改登录密码ToolStripMenuItem.Name = "修改登录密码ToolStripMenuItem";
            this.修改登录密码ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.修改登录密码ToolStripMenuItem.Text = "修改登录密码";
            this.修改登录密码ToolStripMenuItem.Click += new System.EventHandler(this.修改登录密码ToolStripMenuItem_Click);
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.返回ToolStripMenuItem.Text = "退出";
            this.返回ToolStripMenuItem.Click += new System.EventHandler(this.返回ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(175, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎进入火车票订票系统！";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.register_bacg;
            this.ClientSize = new System.Drawing.Size(806, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserHome";
            this.Text = "用户主页";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 列车信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改登录密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}