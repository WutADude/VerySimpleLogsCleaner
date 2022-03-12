
namespace LogsClear
{
    partial class SettingsForm
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
            this.ExtensionsListTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveExtensionsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExtensionsListTB
            // 
            this.ExtensionsListTB.Location = new System.Drawing.Point(6, 19);
            this.ExtensionsListTB.Name = "ExtensionsListTB";
            this.ExtensionsListTB.Size = new System.Drawing.Size(567, 20);
            this.ExtensionsListTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveExtensionsButton);
            this.groupBox1.Controls.Add(this.ExtensionsListTB);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подозрительные расширения:";
            // 
            // SaveExtensionsButton
            // 
            this.SaveExtensionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveExtensionsButton.Location = new System.Drawing.Point(6, 45);
            this.SaveExtensionsButton.Name = "SaveExtensionsButton";
            this.SaveExtensionsButton.Size = new System.Drawing.Size(567, 23);
            this.SaveExtensionsButton.TabIndex = 1;
            this.SaveExtensionsButton.Text = "Сохранить";
            this.SaveExtensionsButton.UseVisualStyleBackColor = true;
            this.SaveExtensionsButton.Click += new System.EventHandler(this.SaveExtensionsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(599, 95);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.EditExtensionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ExtensionsListTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveExtensionsButton;
    }
}