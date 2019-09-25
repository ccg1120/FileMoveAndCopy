
using System.Runtime.Serialization;


namespace FileUtility
{
    [DataContract]
    public class FileMoveSetting
    {
        [DataMember]
        public string Extention;
        [DataMember]
        public string DestinationFolderName;
        [DataMember]
        public string SourceFolderPath;
    }
}
