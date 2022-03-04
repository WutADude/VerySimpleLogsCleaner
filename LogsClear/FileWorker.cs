using System.Collections.Generic;
using System.IO;
using System;
using System.Threading;

namespace LogsClear
{
    public class FileWorker
    {
        public List<string> _FileList = new List<string>();
        public List<string> _SusExtensions = new List<string>() { ".exe", ".bat", ".scr", ".lnk", ".bin", ".cmd", ".js", ".jse", ".gadget", ".jar", ".msi", ".wsf", ".vbs", ".ps1", ".app", ".vb", ".hta" };
        public List<string> _DeletedFiles = new List<string>();
        public int _FilesToCheckCount, _SuspiciousFilesCount;

        public async void BeginWork()
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
                GC.Collect();
            }
        }
    }
}
