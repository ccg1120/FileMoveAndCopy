using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FileUtility
{
    public class JsonUtility
    {
        public static string GetJsonString<T>( T setting) 
        {
            MemoryStream str = new MemoryStream();

            var ser = new DataContractJsonSerializer(typeof(T));

            ser.WriteObject(str, setting);

            byte[] jsondyte = str.ToArray();

            str.Close();
            string result = Encoding.UTF8.GetString(jsondyte, 0, jsondyte.Length);
            Console.WriteLine(result);
            return result;
        }

        public static T ReadToStartSetting<T>(string json) where T : new()
        {
            T deserializedUser = new T();

            Type type = deserializedUser.GetType();

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            var ser = new DataContractJsonSerializer(type);
            
            deserializedUser = (T)ser.ReadObject(ms);
            ms.Close();
            return deserializedUser;
        }

    }
}
