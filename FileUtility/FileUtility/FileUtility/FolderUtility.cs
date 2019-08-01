using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtility
{
    public class FolderUtility
    {
        private static string m_DestFolderPath;
        public static void FolderUtilityInit(string folderPath)
        {
            m_DestFolderPath = folderPath;
            System.Diagnostics.Debug.WriteLine("Init Path : " + m_DestFolderPath);
        }

        public static bool CreateFolder()
        {
            bool result = false;

            DirectoryInfo info = new DirectoryInfo(m_DestFolderPath);

            if (!info.Exists)
            {
                info.Create();
                result = true;
            }
            return result;
        }

    }
}
