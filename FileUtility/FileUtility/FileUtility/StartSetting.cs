using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FileUtility
{
    [DataContract]
    public class StartSetting
    {
        [DataMember]
        public string Version = "1.0.0";
        [DataMember]
        public bool IsLoadStartSetting = false;

        [DataMember]
        public FileMoveSetting FileSetting = new FileMoveSetting();
    }
}
