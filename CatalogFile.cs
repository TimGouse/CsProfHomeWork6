using System;
using System.IO;

namespace CsProfHomeWork6
{
    public class FileArgs : EventArgs
    {
        public string FileName { get; }

        public FileArgs(string fileName)
        {
            FileName = fileName;
        }
    }

    public class DirectoryTraverser
    {
        public event EventHandler<FileArgs> FileFound;
        public bool CancelRequested { get; private set; }

        public void TraverseDirectory(string directoryPath)
        {
            if (CancelRequested) return;

            foreach (var file in Directory.GetFiles(directoryPath))
            {
                OnFileFound(new FileArgs(file));
                if (CancelRequested) return;
            }

            foreach (var subDirectory in Directory.GetDirectories(directoryPath))
            {
                TraverseDirectory(subDirectory);
                if (CancelRequested) return;
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            FileFound?.Invoke(this, e);
        }

        public void CancelTraversal()
        {
            CancelRequested = true;
        }
    }

}
