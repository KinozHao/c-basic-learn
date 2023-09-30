namespace WForms
{
    partial class ButtionShowHello
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
            this.ShowHello = new System.Windows.Forms.TextBox();
            this.ClickMe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowHello
            // 
            this.ShowHello.Location = new System.Drawing.Point(230, 142);
            this.ShowHello.Name = "ShowHello";
            this.ShowHello.Size = new System.Drawing.Size(314, 21);
            this.ShowHello.TabIndex = 0;
            this.ShowHello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClickMe
            // 
            this.ClickMe.Location = new System.Drawing.Point(230, 189);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(136, 51);
            this.ClickMe.TabIndex = 1;
            this.ClickMe.Text = "Touch";
            this.ClickMe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ClickMe.UseVisualStyleBackColor = true;
            this.ClickMe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ClickMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ButtionShowHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClickMe);
            this.Controls.Add(this.ShowHello);
            this.Name = "ButtionShowHello";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowHello;
        private System.Windows.Forms.Button ClickMe;
        private System.Windows.Forms.Button button1;
    }
}

