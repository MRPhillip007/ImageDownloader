using LazyLoader.DI;
using System.Configuration;

namespace LazyLoader.Bll
{
    public class SavedFileActions: ISavedFileActions
    {
        public string GetFileName()
        {
            return ConfigurationManager.AppSettings["file_name"];
        }

        public string GetСompleteFilePath()
        {
            return ConfigurationManager.AppSettings["download_path"] + ConfigurationManager.AppSettings["file_name"];
        }
    }
}