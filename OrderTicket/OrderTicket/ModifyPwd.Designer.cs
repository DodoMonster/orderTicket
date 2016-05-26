namespace OrderTicket
{
    partial class ModifyPwd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.newAgainPwdTextBox = new System.Windows.Forms.TextBox();
            this.newPwdTextBox = new System.Windows.Forms.TextBox();
            this.OriginPwdTextBox = new System.Windows.Forms.TextBox();
            this.originPwdTip = new System.Windows.Forms.Label();
            this.checkOriginPwd = new System.Windows.Forms.Label();
            this.checkNewPwd = new System.Windows.Forms.Label();
            this.newPwdTip = new System.Windows.Forms.Label();
            this.checkAgainPwd = new System.Windows.Forms.Label();
            this.againPwdTip = new System.Windows.Forms.Label();
            this.pwdInputTip = new System.Windows.Forms.Label();
            this.checkUser = new System.Windows.Forms.Label();
            this.checkInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(201, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入原登录密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(201, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "请输入新登录密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(201, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "请再次输入新登录密码：";
            // 
            // modifyButton
            // 
            this.modifyButton.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.modifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyButton.Location = new System.Drawing.Point(390, 362);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 33);
            this.modifyButton.TabIndex = 13;
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
            this.backButton.Location = new System.Drawing.Point(583, 362);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 33);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newAgainPwdTextBox
            // 
            this.newAgainPwdTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newAgainPwdTextBox.Location = new System.Drawing.Point(441, 282);
            this.newAgainPwdTextBox.Name = "newAgainPwdTextBox";
            this.newAgainPwdTextBox.Size = new System.Drawing.Size(176, 26);
            this.newAgainPwdTextBox.TabIndex = 3;
            // 
            // newPwdTextBox
            // 
            this.newPwdTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPwdTextBox.Location = new System.Drawing.Point(441, 197);
            this.newPwdTextBox.Name = "newPwdTextBox";
            this.newPwdTextBox.Size = new System.Drawing.Size(176, 26);
            this.newPwdTextBox.TabIndex = 2;
            this.newPwdTextBox.Enter += new System.EventHandler(this.newPwdTextBox_Enter);
            this.newPwdTextBox.Leave += new System.EventHandler(this.newPwdTextBox_Leave);
            // 
            // OriginPwdTextBox
            // 
            this.OriginPwdTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OriginPwdTextBox.Location = new System.Drawing.Point(441, 117);
            this.OriginPwdTextBox.Name = "OriginPwdTextBox";
            this.OriginPwdTextBox.Size = new System.Drawing.Size(176, 26);
            this.OriginPwdTextBox.TabIndex = 1;
            // 
            // originPwdTip
            // 
            this.originPwdTip.AutoSize = true;
            this.originPwdTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originPwdTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.originPwdTip.ForeColor = System.Drawing.Color.Red;
            this.originPwdTip.Location = new System.Drawing.Point(458, 146);
            this.originPwdTip.Name = "originPwdTip";
            this.originPwdTip.Size = new System.Drawing.Size(135, 20);
            this.originPwdTip.TabIndex = 19;
            this.originPwdTip.Text = "请先输入原登录密码";
            this.originPwdTip.Visible = false;
            // 
            // checkOriginPwd
            // 
            this.checkOriginPwd.AutoSize = true;
            this.checkOriginPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkOriginPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkOriginPwd.ForeColor = System.Drawing.Color.Red;
            this.checkOriginPwd.Location = new System.Drawing.Point(411, 146);
            this.checkOriginPwd.Name = "checkOriginPwd";
            this.checkOriginPwd.Size = new System.Drawing.Size(233, 20);
            this.checkOriginPwd.TabIndex = 20;
            this.checkOriginPwd.Text = "原登录密码输入不正确，请重新输入";
            this.checkOriginPwd.Visible = false;
            // 
            // checkNewPwd
            // 
            this.checkNewPwd.AutoSize = true;
            this.checkNewPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkNewPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkNewPwd.ForeColor = System.Drawing.Color.Red;
            this.checkNewPwd.Location = new System.Drawing.Point(411, 235);
            this.checkNewPwd.Name = "checkNewPwd";
            this.checkNewPwd.Size = new System.Drawing.Size(247, 20);
            this.checkNewPwd.TabIndex = 21;
            this.checkNewPwd.Text = "新登录密码输入不正确！请重新输入！";
            this.checkNewPwd.Visible = false;
            // 
            // newPwdTip
            // 
            this.newPwdTip.AutoSize = true;
            this.newPwdTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPwdTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPwdTip.ForeColor = System.Drawing.Color.Red;
            this.newPwdTip.Location = new System.Drawing.Point(458, 235);
            this.newPwdTip.Name = "newPwdTip";
            this.newPwdTip.Size = new System.Drawing.Size(149, 20);
            this.newPwdTip.TabIndex = 22;
            this.newPwdTip.Text = "请先输入新登录密码！";
            this.newPwdTip.Visible = false;
            // 
            // checkAgainPwd
            // 
            this.checkAgainPwd.AutoSize = true;
            this.checkAgainPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkAgainPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkAgainPwd.ForeColor = System.Drawing.Color.Red;
            this.checkAgainPwd.Location = new System.Drawing.Point(386, 311);
            this.checkAgainPwd.Name = "checkAgainPwd";
            this.checkAgainPwd.Size = new System.Drawing.Size(289, 20);
            this.checkAgainPwd.TabIndex = 23;
            this.checkAgainPwd.Text = "两次输入的新登录密码不相同！请重新输入！";
            this.checkAgainPwd.Visible = false;
            // 
            // againPwdTip
            // 
            this.againPwdTip.AutoSize = true;
            this.againPwdTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.againPwdTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.againPwdTip.ForeColor = System.Drawing.Color.Red;
            this.againPwdTip.Location = new System.Drawing.Point(444, 311);
            this.againPwdTip.Name = "againPwdTip";
            this.againPwdTip.Size = new System.Drawing.Size(163, 20);
            this.againPwdTip.TabIndex = 24;
            this.againPwdTip.Text = "请重复输入新登录密码！";
            this.againPwdTip.Visible = false;
            // 
            // pwdInputTip
            // 
            this.pwdInputTip.AutoSize = true;
            this.pwdInputTip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pwdInputTip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdInputTip.ForeColor = System.Drawing.Color.Green;
            this.pwdInputTip.Location = new System.Drawing.Point(623, 198);
            this.pwdInputTip.Name = "pwdInputTip";
            this.pwdInputTip.Size = new System.Drawing.Size(173, 20);
            this.pwdInputTip.TabIndex = 25;
            this.pwdInputTip.Text = "请输入6到10位的新密码！";
            this.pwdInputTip.Visible = false;
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkUser.ForeColor = System.Drawing.Color.Red;
            this.checkUser.Location = new System.Drawing.Point(313, 83);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(177, 20);
            this.checkUser.TabIndex = 26;
            this.checkUser.Text = "用户不存在！请重新确认！";
            this.checkUser.Visible = false;
            // 
            // checkInfoButton
            // 
            this.checkInfoButton.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.checkInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkInfoButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkInfoButton.Location = new System.Drawing.Point(160, 362);
            this.checkInfoButton.Name = "checkInfoButton";
            this.checkInfoButton.Size = new System.Drawing.Size(119, 33);
            this.checkInfoButton.TabIndex = 27;
            this.checkInfoButton.Text = "查看我的资料";
            this.checkInfoButton.UseVisualStyleBackColor = true;
            this.checkInfoButton.Click += new System.EventHandler(this.checkInfoButton_Click);
            // 
            // ModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.register;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.checkInfoButton);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.pwdInputTip);
            this.Controls.Add(this.againPwdTip);
            this.Controls.Add(this.checkAgainPwd);
            this.Controls.Add(this.newPwdTip);
            this.Controls.Add(this.checkNewPwd);
            this.Controls.Add(this.checkOriginPwd);
            this.Controls.Add(this.originPwdTip);
            this.Controls.Add(this.OriginPwdTextBox);
            this.Controls.Add(this.newPwdTextBox);
            this.Controls.Add(this.newAgainPwdTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModifyPwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox newAgainPwdTextBox;
        private System.Windows.Forms.TextBox newPwdTextBox;
        private System.Windows.Forms.TextBox OriginPwdTextBox;
        private System.Windows.Forms.Label originPwdTip;
        private System.Windows.Forms.Label checkOriginPwd;
        private System.Windows.Forms.Label checkNewPwd;
        private System.Windows.Forms.Label newPwdTip;
        private System.Windows.Forms.Label checkAgainPwd;
        private System.Windows.Forms.Label againPwdTip;
        private System.Windows.Forms.Label pwdInputTip;
        private System.Windows.Forms.Label checkUser;
        private System.Windows.Forms.Button checkInfoButton;
    }
}