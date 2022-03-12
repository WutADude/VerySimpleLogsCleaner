using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsClear
{
    public partial class SettingsForm : Form
    {
        public FileWorker _FileWorker;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void EditExtensionsForm_Load(object sender, EventArgs e)
        {
            string ReadyString = null;
            foreach (string Extension in _FileWorker._SusExtensions)
                ReadyString += $"{Extension} ";
            ExtensionsListTB.Text = ReadyString;
        }

        private void SaveExtensionsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExtensionsList = ExtensionsListTB.Text.ToLower().TrimEnd(' ');
            Properties.Settings.Default.Save();
            _FileWorker.ReadSavedSusExtensions();
        }
    }
}
