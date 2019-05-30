namespace sqlToEntity
{
    partial class frmPlus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkIsAllowNull = new System.Windows.Forms.CheckBox();
            this.chkIsAttr = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkIsUpper = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSourceTxt = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResultTxt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkIsAllowNull);
            this.panel1.Controls.Add(this.chkIsAttr);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chkIsUpper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 125);
            this.panel1.TabIndex = 6;
            // 
            // chkIsAllowNull
            // 
            this.chkIsAllowNull.AutoSize = true;
            this.chkIsAllowNull.Location = new System.Drawing.Point(28, 20);
            this.chkIsAllowNull.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsAllowNull.Name = "chkIsAllowNull";
            this.chkIsAllowNull.Size = new System.Drawing.Size(181, 19);
            this.chkIsAllowNull.TabIndex = 2;
            this.chkIsAllowNull.Text = "属性值是否允许为null";
            this.chkIsAllowNull.UseVisualStyleBackColor = true;
            this.chkIsAllowNull.CheckedChanged += new System.EventHandler(this.chkIsAllowNull_CheckedChanged);
            // 
            // chkIsAttr
            // 
            this.chkIsAttr.AutoSize = true;
            this.chkIsAttr.Location = new System.Drawing.Point(28, 79);
            this.chkIsAttr.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsAttr.Name = "chkIsAttr";
            this.chkIsAttr.Size = new System.Drawing.Size(149, 19);
            this.chkIsAttr.TabIndex = 3;
            this.chkIsAttr.Text = "属性是否使用标注";
            this.chkIsAttr.UseVisualStyleBackColor = true;
            this.chkIsAttr.CheckedChanged += new System.EventHandler(this.chkIsAttr_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(471, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "格式化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkIsUpper
            // 
            this.chkIsUpper.AutoSize = true;
            this.chkIsUpper.Location = new System.Drawing.Point(28, 51);
            this.chkIsUpper.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsUpper.Name = "chkIsUpper";
            this.chkIsUpper.Size = new System.Drawing.Size(134, 19);
            this.chkIsUpper.TabIndex = 2;
            this.chkIsUpper.Text = "属性名是否大写";
            this.chkIsUpper.UseVisualStyleBackColor = true;
            this.chkIsUpper.CheckedChanged += new System.EventHandler(this.chkIsUpper_CheckedChanged);
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
            this.tabControl1.Size = new System.Drawing.Size(1102, 461);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSourceTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1094, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "初始sql";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSourceTxt
            // 
            this.txtSourceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSourceTxt.Location = new System.Drawing.Point(3, 2);
            this.txtSourceTxt.Margin = new System.Windows.Forms.Padding(0);
            this.txtSourceTxt.Name = "txtSourceTxt";
            this.txtSourceTxt.Size = new System.Drawing.Size(1088, 428);
            this.txtSourceTxt.TabIndex = 0;
            this.txtSourceTxt.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResultTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1094, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "结果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResultTxt
            // 
            this.txtResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultTxt.Location = new System.Drawing.Point(3, 2);
            this.txtResultTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultTxt.Name = "txtResultTxt";
            this.txtResultTxt.Size = new System.Drawing.Size(1088, 428);
            this.txtResultTxt.TabIndex = 0;
            this.txtResultTxt.Text = "";
            // 
            // frmPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPlus";
            this.Text = "frmPlus";
            this.Load += new System.EventHandler(this.frmPlus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkIsAllowNull;
        private System.Windows.Forms.CheckBox chkIsAttr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkIsUpper;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox txtSourceTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtResultTxt;
    }
}