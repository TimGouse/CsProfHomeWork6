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

        public void TraverseDirectory(string directoryPath)
        {
            foreach (var file in Directory.GetFiles(directoryPath))
            {
                OnFileFound(new FileArgs(file));
            }

            foreach (var subDirectory in Directory.GetDirectories(directoryPath))
            {
                TraverseDirectory(subDirectory);
            }
        }

        protected virtual void OnFileFound(FileArgs e)
        {
            EventHandler<FileArgs> handler = FileFound;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
