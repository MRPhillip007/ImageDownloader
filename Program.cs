using LazyLoader.DI;
using LazyLoader.Bll;

namespace LazyLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            IDownloadFile downloadFile = new DownloadFile();
            System.Console.WriteLine(downloadFile.Download());

            IRunFile runFile = new RunFile();
            runFile.Run();
        }
    }
}
