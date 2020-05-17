namespace AISTT
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileM = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileM = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFilem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.fontNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.HPButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BackButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontNum)).BeginInit();
            this.mapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileM,
            this.openFileM,
            this.saveFileM,
            this.saveAsFilem,
            this.toolStripSeparator1,
            this.BackButton,
            this.ClearButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileM
            // 
            this.newFileM.Name = "newFileM";
            this.newFileM.Size = new System.Drawing.Size(180, 22);
            this.newFileM.Text = "New";
            this.newFileM.Click += new System.EventHandler(this.newFileM_Click);
            // 
            // openFileM
            // 
            this.openFileM.Name = "openFileM";
            this.openFileM.Size = new System.Drawing.Size(180, 22);
            this.openFileM.Text = "Open";
            this.openFileM.Click += new System.EventHandler(this.openFileM_Click);
            // 
            // saveFileM
            // 
            this.saveFileM.Name = "saveFileM";
            this.saveFileM.Size = new System.Drawing.Size(180, 22);
            this.saveFileM.Text = "Save";
            this.saveFileM.Click += new System.EventHandler(this.saveFileM_Click);
            // 
            // saveAsFilem
            // 
            this.saveAsFilem.Name = "saveAsFilem";
            this.saveAsFilem.Size = new System.Drawing.Size(180, 22);
            this.saveAsFilem.Text = "Save as";
            this.saveAsFilem.Click += new System.EventHandler(this.saveAsFilem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapPanel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainTextBox);
            this.panel2.Controls.Add(this.fontNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 426);
            this.panel2.TabIndex = 0;
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.EnableAutoDragDrop = true;
            this.mainTextBox.Location = new System.Drawing.Point(7, 26);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(256, 388);
            this.mainTextBox.TabIndex = 3;
            this.mainTextBox.Text = "";
            // 
            // fontNum
            // 
            this.fontNum.Location = new System.Drawing.Point(46, 0);
            this.fontNum.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.fontNum.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.fontNum.Name = "fontNum";
            this.fontNum.Size = new System.Drawing.Size(45, 20);
            this.fontNum.TabIndex = 2;
            this.fontNum.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fontNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шрифт";
            // 
            // mapPanel
            // 
            this.mapPanel.AllowDrop = true;
            this.mapPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mapPanel.Controls.Add(this.button4);
            this.mapPanel.Controls.Add(this.button3);
            this.mapPanel.Controls.Add(this.button2);
            this.mapPanel.Controls.Add(this.button1);
            this.mapPanel.Controls.Add(this.HPButton);
            this.mapPanel.Controls.Add(this.label2);
            this.mapPanel.Controls.Add(this.pictureBox1);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(0, 0);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(530, 426);
            this.mapPanel.TabIndex = 0;
            this.mapPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragDrop);
            this.mapPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragEnter);
            // 
            // HPButton
            // 
            this.HPButton.Location = new System.Drawing.Point(50, 2);
            this.HPButton.Name = "HPButton";
            this.HPButton.Size = new System.Drawing.Size(83, 23);
            this.HPButton.TabIndex = 2;
            this.HPButton.Text = "целое/часть";
            this.HPButton.UseVisualStyleBackColor = true;
            this.HPButton.Click += new System.EventHandler(this.HPButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Связи:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 426);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // BackButton
            // 
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(180, 22);
            this.BackButton.Text = "Отменить";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(180, 22);
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "AIST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontNum)).EndInit();
            this.mapPanel.ResumeLayout(false);
            this.mapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileM;
        private System.Windows.Forms.ToolStripMenuItem openFileM;
        private System.Windows.Forms.ToolStripMenuItem saveFileM;
        private System.Windows.Forms.ToolStripMenuItem saveAsFilem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown fontNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.Button HPButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BackButton;
        private System.Windows.Forms.ToolStripMenuItem ClearButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

