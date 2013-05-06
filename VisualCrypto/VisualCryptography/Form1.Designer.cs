namespace VisualCryptography
{
   partial class Form1
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
      /// 设计器支持所需的方法 - 不要
      /// 使用代码编辑器修改此方法的内容。
      /// </summary>
      private void InitializeComponent()
      {
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBox1.Location = new System.Drawing.Point(10, 24);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(280, 266);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(544, 374);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 1;
         this.button1.Text = "生成";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(226, 331);
         this.textBox1.Name = "textBox1";
         this.textBox1.PasswordChar = '●';
         this.textBox1.Size = new System.Drawing.Size(208, 21);
         this.textBox1.TabIndex = 2;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.pictureBox1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
         this.groupBox1.Size = new System.Drawing.Size(300, 300);
         this.groupBox1.TabIndex = 4;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "密匙";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.pictureBox2);
         this.groupBox2.Location = new System.Drawing.Point(318, 12);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
         this.groupBox2.Size = new System.Drawing.Size(300, 300);
         this.groupBox2.TabIndex = 5;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "消息";
         // 
         // pictureBox2
         // 
         this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBox2.Location = new System.Drawing.Point(10, 24);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(280, 266);
         this.pictureBox2.TabIndex = 0;
         this.pictureBox2.TabStop = false;
         this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(191, 335);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(29, 12);
         this.label1.TabIndex = 6;
         this.label1.Text = "密码";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(191, 362);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(29, 12);
         this.label2.TabIndex = 8;
         this.label2.Text = "消息";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(226, 358);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(76, 21);
         this.textBox2.TabIndex = 7;
         this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ForeColor = System.Drawing.Color.Red;
         this.label3.Location = new System.Drawing.Point(308, 362);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(101, 12);
         this.label3.TabIndex = 9;
         this.label3.Text = "示例只支持一个字";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(631, 409);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label3;
   }
}

