using DataAccess;
using System.Configuration;

namespace Show
{
    class StorageFactory
    {
        private const string SAVE_FORMAT = "FormatSalvare";
        private const string FILE_NAME = "NumeFisier";
        public static DataInterface GetStorageAdministrator()
        {
            var SaveFormat = ConfigurationManager.AppSettings[SAVE_FORMAT];
            var FileName = ConfigurationManager.AppSettings[FILE_NAME];
            if (SaveFormat != null)
            {
                switch (SaveFormat)
                {
                    default:
                    case "bin":
                        return new FileBinaryShowAdmin(FileName + "." + SaveFormat);
                    case "txt":
                        return new FileTextShowAdmin(FileName + "." + SaveFormat);
                }
            }
            return null;
        }
    }
}
