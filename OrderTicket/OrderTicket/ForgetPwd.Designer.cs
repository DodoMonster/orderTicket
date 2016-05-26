namespace OrderTicket
{
    partial class ForgetPwd
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
            this.checkUser = new System.Windows.Forms.Label();
            this.pwdInputTip = new System.Windows.Forms.Label();
            this.againPwdTip = new System.Windows.Forms.Label();
            this.checkAgainPwd = new System.Windows.Forms.Label();
            this.newPwdTip = new System.Windows.Forms.Label();
            this.checkNewPwd = new System.Windows.Forms.Label();
            this.checkID = new System.Windows.Forms.Label();
            this.IDTip = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.newPwdTextBox = new System.Windows.Forms.TextBox();
            this.newAgainPwdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkUser.ForeColor = System.Drawing.Color.Red;
            this.checkUser.Location = new System.Drawing.Point(290, 116);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(177, 20);
            this.checkUser.TabIndex = 40;
            this.checkUser.Text = "用户不存在！请重新确认！";
            this.checkUser.Visible = false;
            // 
            // pwdInputTip
            // 
            this.pwdInputTip.AutoSize = true;
            this.pwdInputTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pwdInputTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdInputTip.ForeColor = System.Drawing.Color.Green;
            this.pwdInputTip.Location = new System.Drawing.Point(527, 236);
            this.pwdInputTip.Name = "pwdInputTip";
            this.pwdInputTip.Size = new System.Drawing.Size(173, 20);
            this.pwdInputTip.TabIndex = 39;
            this.pwdInputTip.Text = "请输入6到10位的新密码！";
            this.pwdInputTip.Visible = false;
            // 
            // againPwdTip
            // 
            this.againPwdTip.AutoSize = true;
            this.againPwdTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.againPwdTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.againPwdTip.ForeColor = System.Drawing.Color.Red;
            this.againPwdTip.Location = new System.Drawing.Point(348, 349);
            this.againPwdTip.Name = "againPwdTip";
            this.againPwdTip.Size = new System.Drawing.Size(163, 20);
            this.againPwdTip.TabIndex = 38;
            this.againPwdTip.Text = "请重复输入新登录密码！";
            this.againPwdTip.Visible = false;
            // 
            // checkAgainPwd
            // 
            this.checkAgainPwd.AutoSize = true;
            this.checkAgainPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkAgainPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkAgainPwd.ForeColor = System.Drawing.Color.Red;
            this.checkAgainPwd.Location = new System.Drawing.Point(290, 349);
            this.checkAgainPwd.Name = "checkAgainPwd";
            this.checkAgainPwd.Size = new System.Drawing.Size(289, 20);
            this.checkAgainPwd.TabIndex = 37;
            this.checkAgainPwd.Text = "两次输入的新登录密码不相同！请重新输入！";
            this.checkAgainPwd.Visible = false;
            // 
            // newPwdTip
            // 
            this.newPwdTip.AutoSize = true;
            this.newPwdTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPwdTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPwdTip.ForeColor = System.Drawing.Color.Red;
            this.newPwdTip.Location = new System.Drawing.Point(362, 273);
            this.newPwdTip.Name = "newPwdTip";
            this.newPwdTip.Size = new System.Drawing.Size(149, 20);
            this.newPwdTip.TabIndex = 36;
            this.newPwdTip.Text = "请先输入新登录密码！";
            this.newPwdTip.Visible = false;
            // 
            // checkNewPwd
            // 
            this.checkNewPwd.AutoSize = true;
            this.checkNewPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkNewPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkNewPwd.ForeColor = System.Drawing.Color.Red;
            this.checkNewPwd.Location = new System.Drawing.Point(315, 273);
            this.checkNewPwd.Name = "checkNewPwd";
            this.checkNewPwd.Size = new System.Drawing.Size(247, 20);
            this.checkNewPwd.TabIndex = 35;
            this.checkNewPwd.Text = "新登录密码输入不正确！请重新输入！";
            this.checkNewPwd.Visible = false;
            // 
            // checkID
            // 
            this.checkID.AutoSize = true;
            this.checkID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkID.ForeColor = System.Drawing.Color.Red;
            this.checkID.Location = new System.Drawing.Point(362, 184);
            this.checkID.Name = "checkID";
            this.checkID.Size = new System.Drawing.Size(247, 20);
            this.checkID.TabIndex = 34;
            this.checkID.Text = "身份证号码输入不正确，请重新输入！";
            this.checkID.Visible = false;
            // 
            // IDTip
            // 
            this.IDTip.AutoSize = true;
            this.IDTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTip.ForeColor = System.Drawing.Color.Red;
            this.IDTip.Location = new System.Drawing.Point(362, 184);
            this.IDTip.Name = "IDTip";
            this.IDTip.Size = new System.Drawing.Size(135, 20);
            this.IDTip.TabIndex = 33;
            this.IDTip.Text = "请先输入身份证号码";
            this.IDTip.Visible = false;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDTextBox.Location = new System.Drawing.Point(345, 155);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(176, 26);
            this.IDTextBox.TabIndex = 27;
            // 
            // newPwdTextBox
            // 
            this.newPwdTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPwdTextBox.Location = new System.Drawing.Point(345, 235);
            this.newPwdTextBox.Name = "newPwdTextBox";
            this.newPwdTextBox.Size = new System.Drawing.Size(176, 26);
            this.newPwdTextBox.TabIndex = 28;
            this.newPwdTextBox.Enter += new System.EventHandler(this.newPwdTextBox_Enter);
            this.newPwdTextBox.Leave += new System.EventHandler(this.newPwdTextBox_Leave);
            // 
            // newAgainPwdTextBox
            // 
            this.newAgainPwdTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newAgainPwdTextBox.Location = new System.Drawing.Point(345, 320);
            this.newAgainPwdTextBox.Name = "newAgainPwdTextBox";
            this.newAgainPwdTextBox.Size = new System.Drawing.Size(176, 26);
            this.newAgainPwdTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(105, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "请再次输入新登录密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(105, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "请输入新登录密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(105, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "请输入您的身份证号码：";
            // 
            // modifyButton
            // 
            this.modifyButton.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.modifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyButton.Location = new System.Drawing.Point(216, 380);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 33);
            this.modifyButton.TabIndex = 41;
            this.modifyButton.Text = "修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButtonClick);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(504, 380);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 33);
            this.backButton.TabIndex = 42;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ForgetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.register;
            this.ClientSize = new System.Drawing.Size(804, 491);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.pwdInputTip);
            this.Controls.Add(this.againPwdTip);
            this.Controls.Add(this.checkAgainPwd);
            this.Controls.Add(this.newPwdTip);
            this.Controls.Add(this.checkNewPwd);
            this.Controls.Add(this.checkID);
            this.Controls.Add(this.IDTip);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.newPwdTextBox);
            this.Controls.Add(this.newAgainPwdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ForgetPwd";
            this.Text = "ForgetPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkUser;
        private System.Windows.Forms.Label pwdInputTip;
        private System.Windows.Forms.Label againPwdTip;
        private System.Windows.Forms.Label checkAgainPwd;
        private System.Windows.Forms.Label newPwdTip;
        private System.Windows.Forms.Label checkNewPwd;
        private System.Windows.Forms.Label checkID;
        private System.Windows.Forms.Label IDTip;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox newPwdTextBox;
        private System.Windows.Forms.TextBox newAgainPwdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button backButton;
    }
}