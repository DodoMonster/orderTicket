namespace OrderTicket
{
    partial class BuyTicket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicket));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkUser = new System.Windows.Forms.Label();
            this.checkUserID = new System.Windows.Forms.Label();
            this.userIDTip = new System.Windows.Forms.Label();
            this.userTip = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.backButton = new System.Windows.Forms.Button();
            this.userControl11 = new QueryTicket.UserControl1();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkUser);
            this.groupBox2.Controls.Add(this.checkUserID);
            this.groupBox2.Controls.Add(this.userIDTip);
            this.groupBox2.Controls.Add(this.userTip);
            this.groupBox2.Controls.Add(this.userIDTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1079, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请输入乘客信息";
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkUser.ForeColor = System.Drawing.Color.Red;
            this.checkUser.Location = new System.Drawing.Point(105, 88);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(149, 20);
            this.checkUser.TabIndex = 6;
            this.checkUser.Text = "请输入正确的乘客姓名";
            this.checkUser.Visible = false;
            // 
            // checkUserID
            // 
            this.checkUserID.AutoSize = true;
            this.checkUserID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkUserID.ForeColor = System.Drawing.Color.Red;
            this.checkUserID.Location = new System.Drawing.Point(678, 88);
            this.checkUserID.Name = "checkUserID";
            this.checkUserID.Size = new System.Drawing.Size(191, 20);
            this.checkUserID.TabIndex = 5;
            this.checkUserID.Text = "请输入正确的乘客身份证号码";
            this.checkUserID.Visible = false;
            // 
            // userIDTip
            // 
            this.userIDTip.AutoSize = true;
            this.userIDTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userIDTip.ForeColor = System.Drawing.Color.Red;
            this.userIDTip.Location = new System.Drawing.Point(678, 88);
            this.userIDTip.Name = "userIDTip";
            this.userIDTip.Size = new System.Drawing.Size(163, 20);
            this.userIDTip.TabIndex = 4;
            this.userIDTip.Text = "请先输入乘客身份证号码";
            this.userIDTip.Visible = false;
            // 
            // userTip
            // 
            this.userTip.AutoSize = true;
            this.userTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userTip.ForeColor = System.Drawing.Color.Red;
            this.userTip.Location = new System.Drawing.Point(105, 88);
            this.userTip.Name = "userTip";
            this.userTip.Size = new System.Drawing.Size(121, 20);
            this.userTip.TabIndex = 3;
            this.userTip.Text = "请先输入乘客姓名";
            this.userTip.Visible = false;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(682, 46);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(229, 29);
            this.userIDTextBox.TabIndex = 2;
            this.userIDTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(523, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "乘客身份证号码：";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(109, 51);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(110, 29);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "乘客姓名：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(992, 229);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(84, 35);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userControl11.Location = new System.Drawing.Point(13, 153);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1078, 1118);
            this.userControl11.TabIndex = 15;
            this.userControl11.UserControlBtnClicked += new QueryTicket.UserControl1.BtnClickHandle(this.InsertData_UserControlBtnClicked);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.ClientSize = new System.Drawing.Size(1100, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BuyTicket";
            this.Text = "购票";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userIDTip;
        private System.Windows.Forms.Label userTip;
        private System.Windows.Forms.Label checkUser;
        private System.Windows.Forms.Label checkUserID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button backButton;
        private QueryTicket.UserControl1 userControl11;
    }
}