using System;
using System.Windows.Forms;

namespace LogsClear
{
    public partial class DeletedFilesForm : Form
    {
        public FileWorker _FileWorker;
        public DeletedFilesForm()
        {
            InitializeComponent();
        }

        private void WriteToList()
        {
            DeletedFilesList.Items.Clear();
            if (_FileWorker._DeletedFiles.Count > 0)
            {
                foreach (string File in _FileWorker._DeletedFiles)
                    DeletedFilesList.Items.Add(File);
            }
            else
                DeletedFilesList.Items.Add("Нет удалённых файлов.");
        }

        private void DeletedFilesForm_Load(object sender, EventArgs e)
        {
            WriteToList();
        }
    }
}
