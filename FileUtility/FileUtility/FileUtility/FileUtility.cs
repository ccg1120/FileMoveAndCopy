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
        private static FileMovePath m_MovePath = new FileMovePath();
        private static FileCopyPath m_CopyPath = new FileCopyPath();

        //private static string m_DestFolderpath; //최종 옮겨질 위치
        //private static string m_SourceFolderpath;   // 옮길 파일 위치
        //private static string m_FileType;   //파일 종류
        
        public static void FileMovesAlltoFolder(FileMovePath path)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Reset();
            sw.Start();
            FileInfo[] fileinfoArray = GetFileinfos(path.m_SourceFolderpath, path.m_FileType);

            for (int i = 0; i < fileinfoArray.Length; i++)
            {
                FileMove(path.m_DestFolderpath, fileinfoArray[i]);
            }
            sw.Stop();
        }

        public static void FileMovePart2Folder(FileMovePath path)
        {
            DirectoryInfo destinfo = new DirectoryInfo(path.m_DestFolderpath);
            FileInfo[] destinfos = destinfo.GetFiles();

            FileInfo[] sourceinfos = GetFileinfos(path.m_SourceFolderpath, path.m_FileType);

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
                    FileMove(path.m_DestFolderpath, sourceinfos[i]);
                }
            }
        }

        public static void FileUtilityInit(string folderpath, string destpath, string filetype)
        {
            m_MovePath.m_SourceFolderpath = folderpath;
            m_MovePath.m_DestFolderpath = destpath;
            m_MovePath.m_FileType = filetype;
        }

        public static void FileCopyPathInit(string folderpath, string destpath, string filetype, string copytype)
        {
            m_CopyPath.m_SourceFolderpath = folderpath;
            m_CopyPath.m_DestFolderpath = destpath;
            m_CopyPath.m_FileType = filetype;
            m_CopyPath.m_CopyType = copytype;
        }

        private static void FileMove(string path, FileInfo info)
        {
            string filename = info.Name;

            string movepath = Path.Combine(path, filename);
            
            File.Move(info.FullName, movepath);
        }

        private static bool CheckFiletypeEqual(string type, string filetype)
        {
            bool result = false;

            if (type.Equals(filetype))
            {
                result = true;
            }
            return result;
        }

        private static FileInfo[] GetFileinfos(string sourcepath, string type)
        {
            DirectoryInfo folderinfo = new DirectoryInfo(sourcepath);

            List<FileInfo> resultlist = new List<FileInfo>();

            FileInfo[] infos = folderinfo.GetFiles();
            for (int i = 0; i < infos.Length; i++)
            {
                string name = infos[i].Name;

                string filetype = GetFileTypetoFilename(name);

                if (CheckFiletypeEqual(type, filetype))
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

    public class FileCopyPath : FileMovePath
    {
        public string m_CopyType;
    }
}
