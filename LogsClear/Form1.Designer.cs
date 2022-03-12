
namespace LogsClear
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TotalFilesCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspiciousFilesDeletedLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LeftFilesCountLabel = new System.Windows.Forms.Label();
            this.DragNDropBox = new System.Windows.Forms.GroupBox();
            this.DropPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DragNDropLabel = new System.Windows.Forms.Label();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.SettingsButton = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.DragNDropBox.SuspendLayout();
            this.DropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Всего файлов:";
            // 
            // TotalFilesCountLabel
            // 
            this.TotalFilesCountLabel.Location = new System.Drawing.Point(84, 13);
            this.TotalFilesCountLabel.Name = "TotalFilesCountLabel";
            this.TotalFilesCountLabel.Size = new System.Drawing.Size(204, 13);
            this.TotalFilesCountLabel.TabIndex = 1;
            this.TotalFilesCountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Непроверенных файлов:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.SettingsButton);
            this.groupBox1.Controls.Add(this.SuspiciousFilesDeletedLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LeftFilesCountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TotalFilesCountLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика:";
            // 
            // SuspiciousFilesDeletedLabel
            // 
            this.SuspiciousFilesDeletedLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuspiciousFilesDeletedLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SuspiciousFilesDeletedLabel.Location = new System.Drawing.Point(143, 39);
            this.SuspiciousFilesDeletedLabel.Name = "SuspiciousFilesDeletedLabel";
            this.SuspiciousFilesDeletedLabel.Size = new System.Drawing.Size(161, 13);
            this.SuspiciousFilesDeletedLabel.TabIndex = 6;
            this.SuspiciousFilesDeletedLabel.TabStop = true;
            this.SuspiciousFilesDeletedLabel.Text = "0";
            this.SuspiciousFilesDeletedLabel.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.SuspiciousFilesDeletedLabel.Click += new System.EventHandler(this.SuspiciousFilesDeletedLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Удалено подозрительных:";
            // 
            // LeftFilesCountLabel
            // 
            this.LeftFilesCountLabel.Location = new System.Drawing.Point(134, 26);
            this.LeftFilesCountLabel.Name = "LeftFilesCountLabel";
            this.LeftFilesCountLabel.Size = new System.Drawing.Size(170, 13);
            this.LeftFilesCountLabel.TabIndex = 3;
            this.LeftFilesCountLabel.Text = "0";
            // 
            // DragNDropBox
            // 
            this.DragNDropBox.Controls.Add(this.DropPanel);
            this.DragNDropBox.Location = new System.Drawing.Point(7, 2);
            this.DragNDropBox.Name = "DragNDropBox";
            this.DragNDropBox.Size = new System.Drawing.Size(310, 165);
            this.DragNDropBox.TabIndex = 4;
            this.DragNDropBox.TabStop = false;
            // 
            // DropPanel
            // 
            this.DropPanel.AllowDrop = true;
            this.DropPanel.Controls.Add(this.label2);
            this.DropPanel.Controls.Add(this.DragNDropLabel);
            this.DropPanel.Location = new System.Drawing.Point(5, 10);
            this.DropPanel.Name = "DropPanel";
            this.DropPanel.Size = new System.Drawing.Size(299, 149);
            this.DropPanel.TabIndex = 2;
            this.DropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragDrop);
            this.DropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(121, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "📂";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragNDropLabel
            // 
            this.DragNDropLabel.Enabled = false;
            this.DragNDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DragNDropLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DragNDropLabel.Location = new System.Drawing.Point(4, 81);
            this.DragNDropLabel.Name = "DragNDropLabel";
            this.DragNDropLabel.Size = new System.Drawing.Size(292, 19);
            this.DragNDropLabel.TabIndex = 1;
            this.DragNDropLabel.Text = "Перетащите папку с логами в эту область";
            this.DragNDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(7, 239);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(310, 17);
            this.MainProgressBar.TabIndex = 5;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(294, 8);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(14, 14);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 262);
            this.Controls.Add(this.MainProgressBar);
            this.Controls.Add(this.DragNDropBox);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple LCleaner by wDude";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DragNDropBox.ResumeLayout(false);
            this.DropPanel.ResumeLayout(false);
            this.DropPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalFilesCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LeftFilesCountLabel;
        private System.Windows.Forms.GroupBox DragNDropBox;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.Label DragNDropLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DropPanel;
        private System.Windows.Forms.LinkLabel SuspiciousFilesDeletedLabel;
        private System.Windows.Forms.Label SettingsButton;
    }
}

