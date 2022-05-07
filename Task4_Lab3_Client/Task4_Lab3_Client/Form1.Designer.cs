namespace Task4_Lab3_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.lV_chat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(112, 369);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(139, 31);
            this.tb_name.TabIndex = 1;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(23, 424);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(364, 43);
            this.tb_message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên";
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(393, 424);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(126, 43);
            this.bt_send.TabIndex = 4;
            this.bt_send.Text = "Gửi";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // lV_chat
            // 
            this.lV_chat.Location = new System.Drawing.Point(35, 12);
            this.lV_chat.Name = "lV_chat";
            this.lV_chat.Size = new System.Drawing.Size(468, 327);
            this.lV_chat.TabIndex = 5;
            this.lV_chat.UseCompatibleStateImageBehavior = false;
            this.lV_chat.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 479);
            this.Controls.Add(this.lV_chat);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_name);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_name;
        private TextBox tb_message;
        private Label label1;
        private Button bt_send;
        private ListView lV_chat;
    }
}