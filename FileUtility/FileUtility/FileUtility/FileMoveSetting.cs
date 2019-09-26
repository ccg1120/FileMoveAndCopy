using System.Runtime.Serialization;


namespace FileUtility
{
    [DataContract]
    public class FileMoveSetting
    {
        [DataMember]
        public bool IsStartLoad = false;
        [DataMember]
        public bool IsChange = false;
        [DataMember]
        public string Extention = string.Empty;
        [DataMember]
        public string DestinationFolderName = string.Empty;
    }
}
