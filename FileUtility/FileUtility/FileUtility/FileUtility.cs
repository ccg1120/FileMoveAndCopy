using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileUtility
{

    
    public class FileUtility
    {
        private static string m_DestFolderpath; //최종 옮겨질 위치
        private static string m_SourceFolderpath;   // 옮길 파일 위치
        private static string m_FileType;   //파일 종류

        public static void FileMovesAlltoFolder()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Reset();
            sw.Start();
            FileInfo[] fileinfoArray = GetFileinfos();

            for (int i = 0; i < fileinfoArray.Length; i++)
            {
                FileMove(fileinfoArray[i]);
            }
            sw.Stop();
            
        }

        public static void FileMovePart2Folder()
        {
            DirectoryInfo destinfo = new DirectoryInfo(m_DestFolderpath);
            FileInfo[] destinfos = destinfo.GetFiles();

            FileInfo[] sourceinfos = GetFileinfos();

            
            for (int i = 0; i < sourceinfos.Length; i++)
            {
                bool havefile = false;
                for (int j = 0; j < destinfos.Length; j++)
                {
                    if(destinfos[j].Name.Equals(sourceinfos[i].Name))
                    {
                        havefile = true;
                        break;
                    }
                }
                if(!havefile)
                {
                    FileMove(sourceinfos[i]);
                }
                
            }
        }

        public static void FileUtilityInit(string folderpath, string destpath, string filetype)
        {
            m_SourceFolderpath = folderpath;
            m_DestFolderpath = destpath;
            m_FileType = filetype;
        }

        private static void FileMove(FileInfo info)
        {
            string filename = info.Name;

            string movepath = Path.Combine(m_DestFolderpath, filename);
            //UnityEngine.Debug.Log("movepath : " + movepath);
            //UnityEngine.Debug.Log("FullName : " + info.FullName);
            File.Move(info.FullName, movepath);
        }

        private static bool CheckFiletypeEqual(string type)
        {
            bool result = false;

            if (m_FileType.Equals(type))
            {
                result = true;
            }
            return result;
        }

        private static FileInfo[] GetFileinfos()
        {
            DirectoryInfo folderinfo = new DirectoryInfo(m_SourceFolderpath);

            List<FileInfo> resultlist = new List<FileInfo>();

            FileInfo[] infos = folderinfo.GetFiles();
            for (int i = 0; i < infos.Length; i++)
            {
                string name = infos[i].Name;

                string filetype = GetFileTypetoFilename(name);

                if (CheckFiletypeEqual(filetype))
                {
                    resultlist.Add(infos[i]);
                }
            }
            return resultlist.ToArray();
        }

        private static string GetFileTypetoFilename(string name)
        {
            string[] splitname = name.Split('.');
            int lastindex = splitname.Length - 1;
            return splitname[lastindex].ToLower();
        }
        private static string GetFileNameWithoutExt(string name)
        {
            string result = string.Empty;



            return result;
        }
    }

    public class FileMovePath
    {
        public string m_DestFolderpath; //최종 옮겨질 위치
        public string m_SourceFolderpath;   // 옮길 파일 위치
        public string m_FileType;   //파일 종류
    }
    public class FileChoicePath
    {
        public string m_DestFolderpath; //최종 옮겨질 위치
        public string m_SourceFolderpath;   // 옮길 파일 위치
        public string m_FileType;   //파일 종류
    }
}
