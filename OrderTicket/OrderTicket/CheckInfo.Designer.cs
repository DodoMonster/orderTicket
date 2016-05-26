namespace OrderTicket
{
    partial class CheckInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modifyPwdButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.myInfo = new System.Windows.Forms.DataGridView();
            this.sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::OrderTicket.Properties.Resources.bacg3;
            this.groupBox1.Controls.Add(this.modifyPwdButton);
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.myInfo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.buyTicketButton);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(36, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 360);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我的个人信息";
            // 
            // modifyPwdButton
            // 
            this.modifyPwdButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifyPwdButton.BackgroundImage")));
            this.modifyPwdButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.modifyPwdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPwdButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifyPwdButton.Location = new System.Drawing.Point(445, 40);
            this.modifyPwdButton.Name = "modifyPwdButton";
            this.modifyPwdButton.Size = new System.Drawing.Size(102, 29);
            this.modifyPwdButton.TabIndex = 8;
            this.modifyPwdButton.Text = "修改密码";
            this.modifyPwdButton.UseVisualStyleBackColor = true;
            this.modifyPwdButton.Click += new System.EventHandler(this.modifyPwdButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(618, 40);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(102, 29);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // myInfo
            // 
            this.myInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.myInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequence,
            this.name,
            this.idNum,
            this.startTime,
            this.trainNum,
            this.startPlace});
            this.myInfo.Location = new System.Drawing.Point(0, 87);
            this.myInfo.Name = "myInfo";
            this.myInfo.RowTemplate.Height = 23;
            this.myInfo.Size = new System.Drawing.Size(743, 273);
            this.myInfo.TabIndex = 6;
            // 
            // sequence
            // 
            this.sequence.HeaderText = "";
            this.sequence.Name = "sequence";
            // 
            // name
            // 
            this.name.DataPropertyName = "user_id";
            this.name.HeaderText = "用户号";
            this.name.Name = "name";
            // 
            // idNum
            // 
            this.idNum.DataPropertyName = "username";
            this.idNum.HeaderText = "姓名";
            this.idNum.Name = "idNum";
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "sex";
            this.startTime.HeaderText = "性别";
            this.startTime.Name = "startTime";
            // 
            // trainNum
            // 
            this.trainNum.DataPropertyName = "idNum";
            this.trainNum.HeaderText = "身份证号码";
            this.trainNum.Name = "trainNum";
            this.trainNum.Width = 200;
            // 
            // startPlace
            // 
            this.startPlace.DataPropertyName = "password";
            this.startPlace.HeaderText = "密码";
            this.startPlace.Name = "startPlace";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(909, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buyTicketButton.BackgroundImage")));
            this.buyTicketButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buyTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicketButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyTicketButton.Location = new System.Drawing.Point(228, 40);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(102, 29);
            this.buyTicketButton.TabIndex = 4;
            this.buyTicketButton.Text = "购票";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // CheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.register_bacg;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckInfo";
            this.Text = "查看个人信息";
            this.Load += new System.EventHandler(this.CheckForm_load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button modifyPwdButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView myInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buyTicketButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPlace;
    }
}