using System.Collections.Generic;
using System.IO;
using System;
using System.Threading;

namespace LogsClear
{
    public class FileWorker
    {
        public List<string> _FileList = new List<string>();
        public List<string> _SusExtensions = new List<string>();
        public List<string> _DeletedFiles = new List<string>();
        public int _FilesToCheckCount, _SuspiciousFilesCount;

        public void BeginWork()
        {
            _FilesToCheckCount = _FileList.Count;
            _SuspiciousFilesCount = 0;
            new Thread(() => SimpleWorker()).Start();
        }

        private void SimpleWorker()
        {
            foreach (string FileToCheck in _FileList) // На самом деле можно было сделать всё куда проще с помощью Linq и его Any + where(e => e.Extension.EndsWith(e)), но кто я такой, чтобы писать такие гениальные вещи? :D
            {
                try
                {
                    if (_SusExtensions.Contains(Path.GetExtension(FileToCheck).ToLower()))
                    {
                        File.Delete(FileToCheck);
                        _SuspiciousFilesCount++;
                        _DeletedFiles.Add(FileToCheck);
                    }
                    _FilesToCheckCount--;
                }
                catch { _FilesToCheckCount--; continue; }
            }
            GC.Collect();
        }

        public void ReadSavedSusExtensions()
        {
            _SusExtensions.Clear(); // Костыль для обновления расширений
            foreach (string Extension in Properties.Settings.Default.ExtensionsList.Trim(new char[] {'"', ',', '-',}).Split(' '))
            {
                if (!_SusExtensions.Contains(Extension))
                    _SusExtensions.Add(Extension);
            }
        }
    }
}
