using System;
using System.IO;


namespace FileUtility
{
    public class UtilityManager
    {
        private FileMovePath m_MovePath = new FileMovePath();
        private FileCopyPath m_CopyPath = new FileCopyPath();


        private string m_DestFolderName = string.Empty;
        private string m_SourceFolderPath = string.Empty;
        private string m_DestFolderPath = string.Empty;
        private string m_FileType = string.Empty;

        private bool m_MoveState = false;

        

        public string MovePath_DestFolderName
        {
            get { return m_MovePath.m_DestFolderName; }
            set { m_MovePath.m_DestFolderName = value; }
        }
        public string MovePath_DestFolderpath
        {
            get { return m_MovePath.m_DestFolderpath; }
            //set { m_DestFolderPath = value; }
        }
        public string MovePath_SourceFolderpath
        {
            get { return m_MovePath.m_SourceFolderpath; }
            set { m_MovePath.m_SourceFolderpath = value; }
        }
        public string MovePath_FileType
        {
            get { return m_MovePath.m_FileType; }
            set { m_MovePath.FileType = value; }
        }
   

        public void FolderPathSetting()
        {
            m_DestFolderPath = Path.Combine(m_SourceFolderPath, m_DestFolderName);
            FolderUtility.FolderUtilityInit(m_DestFolderPath);

            m_MovePath.m_SourceFolderpath = m_SourceFolderPath;
            m_MovePath.m_DestFolderpath = m_DestFolderPath;
            m_MovePath.m_FileType = m_FileType;

            FileUtility.FileUtilityInit(m_SourceFolderPath, m_DestFolderPath, m_FileType);
        }

        public void CopyPathSetting()
        {
            //TODO : 파일복사 경로 입력 UI구성 후 진행

        }

        private bool CheckState_FileMove()
        {
            bool result = true;

            if (m_DestFolderName.Equals(string.Empty))
            {
                result = false;
            }
            if (m_SourceFolderPath.Equals(string.Empty))
            {
                result = false;
            }
            if (m_DestFolderPath.Equals(string.Empty))
            {
                result = false;
            }
            if (m_FileType.Equals(string.Empty))
            {
                result = false;
            }
            return result;
        }



        public void CreateAction(Action finishact)
        {
            if(!CheckState_FileMove())
            {
                return;
            }
            if (FolderUtility.CreateFolder())
            {
                FileUtility.FileMovesAlltoFolder(m_MovePath);
            }
            else
            {
                FileUtility.FileMovePart2Folder(m_MovePath);
            }
            finishact.Invoke();
        }
    }
}
