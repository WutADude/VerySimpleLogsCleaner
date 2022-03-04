﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LogsClear
{
    public partial class MainForm : Form
    {
        public FileWorker _FileWorker = new FileWorker();
        public MainForm()
        {
            InitializeComponent();
            CounterUpdater().ConfigureAwait(false);
            
        }

        private void DropPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string LogsPath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(LogsPath))
                {
                    _FileWorker._FileList.Clear();
                    _FileWorker._DeletedFiles.Clear();
                    MainProgressBar.Value = 0;
                    DragNDropLabel.Text = LogsPath;
                    foreach (string File in Directory.GetFiles(LogsPath, "*" ,SearchOption.AllDirectories))
                        _FileWorker._FileList.Add(File);
                    MainProgressBar.Maximum = _FileWorker._FileList.Count;
                    _FileWorker.BeginWork();
                }
                else
                    MessageBox.Show("Необходимо перетащить папку с логами, а не что-то другое!", "Тащим только логи", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DropPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private async Task CounterUpdater()
        {
            while (true)
            {
                TotalFilesCountLabel.Text = _FileWorker._FileList.Count.ToString();
                LeftFilesCountLabel.Text = _FileWorker._FilesToCheckCount.ToString();
                SuspiciousFilesDeletedLabel.Text = _FileWorker._SuspiciousFilesCount.ToString();
                MainProgressBar.Value = _FileWorker._FileList.Count - _FileWorker._FilesToCheckCount;
                await Task.Delay(250);
            }
        }

        private void SuspiciousFilesDeletedLabel_Click(object sender, EventArgs e)
        {
            DeletedFilesForm _DForm = new DeletedFilesForm();
            _DForm._FileWorker = _FileWorker;
            _DForm.Show();
        }
    }

}