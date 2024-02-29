namespace WinFormEventsExample3
{
    partial class MyForm1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 28);
            this.textBox1.TabIndex = 0;
            // 
            // MyButton
            // 
            this.MyButton.Location = new System.Drawing.Point(592, 169);
            this.MyButton.Name = "MyButton";
            this.MyButton.Size = new System.Drawing.Size(141, 61);
            this.MyButton.TabIndex = 1;
            this.MyButton.Text = "Say hello";
            this.MyButton.UseVisualStyleBackColor = true;
            //new一个委托接收click事件,有两种写法
            //this.MyButton.Click += new System.EventHandler(this.button1_Click);
            this.MyButton.Click += this.button1_Click;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 573);
            this.Controls.Add(this.MyButton);
            this.Controls.Add(this.textBox1);
            this.Name = "MyForm";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MyButton;
    }
}

