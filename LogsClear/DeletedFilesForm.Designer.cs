
namespace LogsClear
{
    partial class DeletedFilesForm
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
            this.DeletedFilesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeletedFilesList
            // 
            this.DeletedFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeletedFilesList.FormattingEnabled = true;
            this.DeletedFilesList.HorizontalScrollbar = true;
            this.DeletedFilesList.Location = new System.Drawing.Point(12, 12);
            this.DeletedFilesList.Name = "DeletedFilesList";
            this.DeletedFilesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DeletedFilesList.Size = new System.Drawing.Size(775, 156);
            this.DeletedFilesList.TabIndex = 1;
            this.DeletedFilesList.TabStop = false;
            this.DeletedFilesList.UseTabStops = false;
            // 
            // DeletedFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 179);
            this.Controls.Add(this.DeletedFilesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeletedFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалённые из логов файлы";
            this.Load += new System.EventHandler(this.DeletedFilesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DeletedFilesList;
    }
}