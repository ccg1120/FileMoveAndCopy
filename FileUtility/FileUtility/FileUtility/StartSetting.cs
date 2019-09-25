﻿using System;
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
        public string Version;
        [DataMember]
        public bool IsLoadStartSetting;

        public static string GetJsonString(StartSetting setting)
        {
            MemoryStream str = new MemoryStream();

            var ser = new DataContractJsonSerializer(typeof(StartSetting));

            ser.WriteObject(str, setting);

            byte[] jsondyte = str.ToArray();

            str.Close();
            string result = Encoding.UTF8.GetString(jsondyte, 0, jsondyte.Length);
            Console.WriteLine(result);
            return result;
        }

        public static StartSetting ReadToStartSetting(string json)
        {
            var deserializedUser = new StartSetting();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var ser = new DataContractJsonSerializer(deserializedUser.GetType());
            deserializedUser = ser.ReadObject(ms) as StartSetting;
            ms.Close();
            return deserializedUser;
        }
    }


    
}
