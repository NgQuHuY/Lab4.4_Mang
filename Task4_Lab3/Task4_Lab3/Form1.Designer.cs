namespace Task4_Lab3
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
            this.lV_chat = new System.Windows.Forms.ListView();
            this.bt_Listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lV_chat
            // 
            this.lV_chat.Location = new System.Drawing.Point(12, 12);
            this.lV_chat.Name = "lV_chat";
            this.lV_chat.Size = new System.Drawing.Size(562, 366);
            this.lV_chat.TabIndex = 0;
            this.lV_chat.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Listen
            // 
            this.bt_Listen.Location = new System.Drawing.Point(229, 394);
            this.bt_Listen.Name = "bt_Listen";
            this.bt_Listen.Size = new System.Drawing.Size(112, 34);
            this.bt_Listen.TabIndex = 1;
            this.bt_Listen.Text = "Listen";
            this.bt_Listen.UseVisualStyleBackColor = true;
            this.bt_Listen.Click += new System.EventHandler(this.bt_Listen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.bt_Listen);
            this.Controls.Add(this.lV_chat);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lV_chat;
        private Button bt_Listen;
    }
}