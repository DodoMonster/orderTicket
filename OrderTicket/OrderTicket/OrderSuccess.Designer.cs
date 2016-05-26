namespace OrderTicket
{
    partial class OrderSuccess
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
            this.queryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(166, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "订票成功！请及时获取纸质车票！";
            // 
            // queryButton
            // 
            this.queryButton.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.queryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.queryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryButton.Location = new System.Drawing.Point(206, 385);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(119, 30);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "点击查询订单";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::OrderTicket.Properties.Resources.bacg;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.Location = new System.Drawing.Point(470, 385);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 30);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OrderSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OrderTicket.Properties.Resources.register_bacg;
            this.ClientSize = new System.Drawing.Size(776, 496);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.label2);
            this.Name = "OrderSuccess";
            this.Text = "订票成功提示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button backButton;
    }
}