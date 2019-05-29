namespace sqlToEntity
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSourceTxt = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResultTxt = new System.Windows.Forms.RichTextBox();
            this.chkIsAllowNull = new System.Windows.Forms.CheckBox();
            this.chkIsUpper = new System.Windows.Forms.CheckBox();
            this.chkIsAttr = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "格式化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSourceTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(852, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSourceTxt
            // 
            this.txtSourceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourceTxt.Location = new System.Drawing.Point(2, 2);
            this.txtSourceTxt.Margin = new System.Windows.Forms.Padding(0);
            this.txtSourceTxt.Name = "txtSourceTxt";
            this.txtSourceTxt.Size = new System.Drawing.Size(848, 339);
            this.txtSourceTxt.TabIndex = 0;
            this.txtSourceTxt.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResultTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(852, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "结果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResultTxt
            // 
            this.txtResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultTxt.Location = new System.Drawing.Point(2, 2);
            this.txtResultTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResultTxt.Name = "txtResultTxt";
            this.txtResultTxt.Size = new System.Drawing.Size(848, 339);
            this.txtResultTxt.TabIndex = 0;
            this.txtResultTxt.Text = "";
            // 
            // chkIsAllowNull
            // 
            this.chkIsAllowNull.AutoSize = true;
            this.chkIsAllowNull.Location = new System.Drawing.Point(21, 16);
            this.chkIsAllowNull.Name = "chkIsAllowNull";
            this.chkIsAllowNull.Size = new System.Drawing.Size(144, 16);
            this.chkIsAllowNull.TabIndex = 2;
            this.chkIsAllowNull.Text = "属性值是否允许为null";
            this.chkIsAllowNull.UseVisualStyleBackColor = true;
            this.chkIsAllowNull.CheckedChanged += new System.EventHandler(this.chkIsAllowNull_CheckedChanged);
            // 
            // chkIsUpper
            // 
            this.chkIsUpper.AutoSize = true;
            this.chkIsUpper.Location = new System.Drawing.Point(21, 41);
            this.chkIsUpper.Name = "chkIsUpper";
            this.chkIsUpper.Size = new System.Drawing.Size(108, 16);
            this.chkIsUpper.TabIndex = 2;
            this.chkIsUpper.Text = "属性名是否大写";
            this.chkIsUpper.UseVisualStyleBackColor = true;
            this.chkIsUpper.CheckedChanged += new System.EventHandler(this.chkIsUpper_CheckedChanged);
            // 
            // chkIsAttr
            // 
            this.chkIsAttr.AutoSize = true;
            this.chkIsAttr.Location = new System.Drawing.Point(21, 63);
            this.chkIsAttr.Name = "chkIsAttr";
            this.chkIsAttr.Size = new System.Drawing.Size(120, 16);
            this.chkIsAttr.TabIndex = 3;
            this.chkIsAttr.Text = "属性是否使用标注";
            this.chkIsAttr.UseVisualStyleBackColor = true;
            this.chkIsAttr.CheckedChanged += new System.EventHandler(this.chkIsAttr_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkIsAllowNull);
            this.panel1.Controls.Add(this.chkIsAttr);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chkIsUpper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 100);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "SqlEntityFormatter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox txtSourceTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtResultTxt;
        private System.Windows.Forms.CheckBox chkIsAllowNull;
        private System.Windows.Forms.CheckBox chkIsUpper;
        private System.Windows.Forms.CheckBox chkIsAttr;
        private System.Windows.Forms.Panel panel1;
    }
}

