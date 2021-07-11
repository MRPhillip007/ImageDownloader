using LazyLoader.DI;
using System.Net;
using System.Net.NetworkInformation;

namespace LazyLoader.Bll
{
    public class DownloadFile: SavedFileActions, IDownloadFile
    {
        public string Download()
        {
            SavedFileActions savedFile = new SavedFileActions();
            string FileDownloadPath = savedFile.GetСompleteFilePath();

            if(NetworkInterface.GetIsNetworkAvailable())
            {

                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://i.imgflip.com/1wekwd.jpg", FileDownloadPath);
            }

            else
            {
                return "Check Internet connection! ";
            }


            return "Download Completed! ";

        }
    }
}