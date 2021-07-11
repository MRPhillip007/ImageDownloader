using LazyLoader.DI;
using System.Diagnostics;

namespace LazyLoader.Bll
{
    public class RunFile: SavedFileActions , IRunFile
    {
        public void Run()
        {
            SavedFileActions savedFile = new SavedFileActions();
            string FilePath = savedFile.GetСompleteFilePath();

            ProcessStartInfo procInfo = new ProcessStartInfo();
            procInfo.FileName = FilePath;                                               
            procInfo.UseShellExecute = true;                                                    // Remove for exec files
            Process.Start(procInfo);
        }
    }
}