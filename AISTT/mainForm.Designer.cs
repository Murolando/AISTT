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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BackButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExampleBut = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.fontNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Value = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescButton = new System.Windows.Forms.Button();
            this.HPButton = new System.Windows.Forms.Button();
            this.AKOButton = new System.Windows.Forms.Button();
            this.IsAButton = new System.Windows.Forms.Button();
            this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.openTextFileToolStripMenuItem,
            this.openFileM,
            this.ExampleBut,
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
            // ExampleBut
            // 
            this.ExampleBut.Name = "ExampleBut";
            this.ExampleBut.Size = new System.Drawing.Size(180, 22);
            this.ExampleBut.Text = "Examples";
            this.ExampleBut.Click += new System.EventHandler(this.ExampleBut_Click);
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
            this.splitContainer1.Panel2.Controls.Add(this.Value);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.DescButton);
            this.splitContainer1.Panel2.Controls.Add(this.HPButton);
            this.splitContainer1.Panel2.Controls.Add(this.AKOButton);
            this.splitContainer1.Panel2.Controls.Add(this.IsAButton);
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
            this.mapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mapPanel.Controls.Add(this.pictureBox1);
            this.mapPanel.Location = new System.Drawing.Point(0, 31);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(530, 395);
            this.mapPanel.TabIndex = 0;
            this.mapPanel.SizeChanged += new System.EventHandler(this.mapPanel_SizeChanged);
            this.mapPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragDrop);
            this.mapPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.mapPanel_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 395);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.mapPanel_SizeChanged);
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Value.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Value.Location = new System.Drawing.Point(382, 2);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(75, 23);
            this.Value.TabIndex = 8;
            this.Value.Text = "величина";
            this.Value.UseVisualStyleBackColor = false;
            this.Value.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Связи:";
            // 
            // DescButton
            // 
            this.DescButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DescButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescButton.Location = new System.Drawing.Point(301, 2);
            this.DescButton.Name = "DescButton";
            this.DescButton.Size = new System.Drawing.Size(75, 23);
            this.DescButton.TabIndex = 7;
            this.DescButton.Text = "определение";
            this.DescButton.UseVisualStyleBackColor = false;
            this.DescButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // HPButton
            // 
            this.HPButton.BackColor = System.Drawing.Color.Lime;
            this.HPButton.FlatAppearance.BorderSize = 0;
            this.HPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HPButton.Location = new System.Drawing.Point(50, 2);
            this.HPButton.Name = "HPButton";
            this.HPButton.Size = new System.Drawing.Size(83, 23);
            this.HPButton.TabIndex = 2;
            this.HPButton.Text = "целое/часть";
            this.HPButton.UseVisualStyleBackColor = false;
            this.HPButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // AKOButton
            // 
            this.AKOButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AKOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AKOButton.Location = new System.Drawing.Point(220, 2);
            this.AKOButton.Name = "AKOButton";
            this.AKOButton.Size = new System.Drawing.Size(75, 23);
            this.AKOButton.TabIndex = 6;
            this.AKOButton.Text = "свойства";
            this.AKOButton.UseVisualStyleBackColor = false;
            this.AKOButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // IsAButton
            // 
            this.IsAButton.BackColor = System.Drawing.Color.Red;
            this.IsAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsAButton.Location = new System.Drawing.Point(139, 2);
            this.IsAButton.Name = "IsAButton";
            this.IsAButton.Size = new System.Drawing.Size(75, 23);
            this.IsAButton.TabIndex = 5;
            this.IsAButton.Text = "относится к";
            this.IsAButton.UseVisualStyleBackColor = false;
            this.IsAButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // openTextFileToolStripMenuItem
            // 
            this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
            this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openTextFileToolStripMenuItem.Text = "Open Text File";
            this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.openTextFileToolStripMenuItem_Click);
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
            this.SizeChanged += new System.EventHandler(this.mapPanel_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontNum)).EndInit();
            this.mapPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BackButton;
        private System.Windows.Forms.ToolStripMenuItem ClearButton;
        private System.Windows.Forms.Button Value;
        private System.Windows.Forms.Button DescButton;
        private System.Windows.Forms.Button AKOButton;
        private System.Windows.Forms.Button IsAButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ExampleBut;
        private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
    }
}

