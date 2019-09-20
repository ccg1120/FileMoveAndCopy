using System;
using System.IO;

namespace FileUtility
{
    class StartSettingManager
    {
        private string m_SettingFolderName = "Setting";
        private string m_SaveFileExtention = ".json";
        private string m_SaveFileName = "StartOption";
        private string m_SettingPath = string.Empty;

        private void CheckSettingPathAndCreateFolder()
        {
            m_SettingPath = Path.Combine(Directory.GetCurrentDirectory(), m_SettingFolderName);
            Console.WriteLine();

            DirectoryInfo info = new DirectoryInfo(m_SettingPath);

            if(!info.Exists)
            {
                info.Create();
            }
        }
        private void CheckSettingFileAndCreateEmptyFile()
        {
            m_SettingPath = Path.Combine(Directory.GetCurrentDirectory(), m_SettingFolderName);
            Console.WriteLine();

            DirectoryInfo info = new DirectoryInfo(m_SettingPath);

            if (!info.Exists)
            {
                info.Create();
            }
        }

    }
}
