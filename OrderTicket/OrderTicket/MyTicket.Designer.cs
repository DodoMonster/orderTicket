namespace OrderTicket
{
    partial class MyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTicket));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.myTicketInfo = new System.Windows.Forms.DataGridView();
            this.buyButton = new System.Windows.Forms.Button();
            this.订单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出发地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出发日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出发时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目的地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.到达日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.到达时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.车票ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myTicketInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::OrderTicket.Properties.Resources.bacg3;
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.myTicketInfo);
            this.groupBox1.Controls.Add(this.buyButton);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1416, 455);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我的订单";
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(805, 44);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 29);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // myTicketInfo
            // 
            this.myTicketInfo.AllowUserToOrderColumns = true;
            this.myTicketInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.myTicketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTicketInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单号,
            this.姓名,
            this.身份证号码,
            this.车次,
            this.出发地,
            this.出发日,
            this.出发时间,
            this.目的地,
            this.到达日,
            this.到达时间,
            this.价格,
            this.备注,
            this.车票ID,
            this.用户ID});
            this.myTicketInfo.Location = new System.Drawing.Point(0, 89);
            this.myTicketInfo.Name = "myTicketInfo";
            this.myTicketInfo.RowTemplate.Height = 23;
            this.myTicketInfo.Size = new System.Drawing.Size(1276, 451);
            this.myTicketInfo.TabIndex = 6;
            this.myTicketInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myTicketInfo_CellContentClick);
            // 
            // buyButton
            // 
            this.buyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buyButton.BackgroundImage")));
            this.buyButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyButton.Location = new System.Drawing.Point(664, 44);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 29);
            this.buyButton.TabIndex = 4;
            this.buyButton.Text = "购票";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // 订单号
            // 
            this.订单号.DataPropertyName = "order_id";
            this.订单号.HeaderText = "订单号";
            this.订单号.Name = "订单号";
            this.订单号.Width = 70;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "username";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // 身份证号码
            // 
            this.身份证号码.DataPropertyName = "idNum";
            this.身份证号码.HeaderText = "身份证号码";
            this.身份证号码.Name = "身份证号码";
            this.身份证号码.Width = 200;
            // 
            // 车次
            // 
            this.车次.DataPropertyName = "ticketNO";
            this.车次.HeaderText = "车次";
            this.车次.Name = "车次";
            this.车次.Width = 70;
            // 
            // 出发地
            // 
            this.出发地.DataPropertyName = "startPlace";
            this.出发地.HeaderText = "出发地";
            this.出发地.Name = "出发地";
            // 
            // 出发日
            // 
            this.出发日.DataPropertyName = "startDay";
            this.出发日.HeaderText = "出发日";
            this.出发日.Name = "出发日";
            // 
            // 出发时间
            // 
            this.出发时间.DataPropertyName = "startTime";
            this.出发时间.HeaderText = "出发时间";
            this.出发时间.Name = "出发时间";
            // 
            // 目的地
            // 
            this.目的地.DataPropertyName = "destination";
            this.目的地.HeaderText = "目的地";
            this.目的地.Name = "目的地";
            // 
            // 到达日
            // 
            this.到达日.DataPropertyName = "achieveDay";
            this.到达日.HeaderText = "到达日";
            this.到达日.Name = "到达日";
            // 
            // 到达时间
            // 
            this.到达时间.DataPropertyName = "achieveTime";
            this.到达时间.HeaderText = "到达时间";
            this.到达时间.Name = "到达时间";
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "price";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            // 
            // 备注
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.NullValue = "退票";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.备注.DefaultCellStyle = dataGridViewCellStyle1;
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.Width = 70;
            // 
            // 车票ID
            // 
            this.车票ID.DataPropertyName = "ticket_id";
            this.车票ID.HeaderText = "车票ID";
            this.车票ID.Name = "车票ID";
            this.车票ID.Width = 5;
            // 
            // 用户ID
            // 
            this.用户ID.DataPropertyName = "user_id";
            this.用户ID.HeaderText = "用户ID";
            this.用户ID.Name = "用户ID";
            this.用户ID.Width = 5;
            // 
            // MyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.ClientSize = new System.Drawing.Size(1413, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyTicket";
            this.Text = "我的订单";
            this.Load += new System.EventHandler(this.MyTicket_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myTicketInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.DataGridView myTicketInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出发地;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出发日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出发时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目的地;
        private System.Windows.Forms.DataGridViewTextBoxColumn 到达日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 到达时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewButtonColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车票ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户ID;
    }
}