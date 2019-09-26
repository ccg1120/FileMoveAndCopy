using System;
using System.IO;

namespace FileUtility
{
    public class StartSettingManager
    {
        private static StartSetting m_Setting;

        private static string m_SettingFolderName = "Setting";
        private static string m_SaveFileExtention = ".json";
        private static string m_SaveFileName = "StartOption";
        private static string m_SettingPath = string.Empty;
        private static string m_SettingFileFullPath = string.Empty;

        public static FileMoveSetting GetFileMoveSetting()
        {
            return m_Setting.FileSetting;
        }

        public static void StartSettingInit()
        {
            CheckSettingPathAndCreateFolder();

            if(CheckSettingFileAndCreateEmptyFile())
            {
                m_Setting = LoadStartSetting();
            }
            else
            {
                m_Setting = CreateDefalt();
                SaveSettingFile();
            }

        }

        public static void SetStartOption()
        {
            if(m_Setting.IsLoadStartSetting)
            {
                Program.startform.LoadExtentionSetting(m_Setting.FileSetting);
            }
        }

        private static void CheckSettingPathAndCreateFolder()
        {
            m_SettingPath = Path.Combine(Directory.GetCurrentDirectory(), m_SettingFolderName);
            Console.WriteLine("paht = {0}", m_SettingPath);

            DirectoryInfo info = new DirectoryInfo(m_SettingPath);

            if(!info.Exists)
            {
                info.Create();
            }
        }

        private static StartSetting LoadStartSetting()
        {
            StartSetting  temp = new StartSetting();
            string json = File.ReadAllText(m_SettingFileFullPath, System.Text.Encoding.UTF8);
            //temp = StartSetting.ReadToStartSetting(json);
            temp = JsonUtility.ReadToStartSetting<StartSetting>(json);
            return temp;
        }

        private static void SaveSettingFile()
        {
            if(m_Setting == null)
            {
                return;
            }
            if(m_SettingFileFullPath.Equals(string.Empty))
            {
                return;
            }

            //string json = StartSetting.GetJsonString(m_Setting);
            string json = JsonUtility.GetJsonString<StartSetting>(m_Setting);

            File.WriteAllText(m_SettingFileFullPath, json);
        }

        private static StartSetting CreateDefalt()
        {
            StartSetting result = new StartSetting();
            //result.Version = m_Version;
            result.IsLoadStartSetting = false;
            return result;
        }

        private static T CreateDefalt<T>() where T : new()
        {
            T result = new T();
            return result;
        }

        private static bool CheckSettingFileAndCreateEmptyFile()
        {
            string filename = m_SaveFileName + m_SaveFileExtention;

            m_SettingFileFullPath = Path.Combine(m_SettingPath, filename);

            Console.WriteLine("file path = {0}", m_SettingFileFullPath);
            
            FileInfo info = new FileInfo(m_SettingFileFullPath);

            if (!info.Exists)
            {
                info.Create().Close();
                return false;
            }

            return true;    
        }

    }
}
