using AudioLib.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AudioLib.Actions
{
    public class JsonHandler : IDatabaseActions
    {
        public static T JsonToObject<T>(string jsonString)
        {
            object obj = JsonConvert.SerializeObject(jsonString);


            return (T)obj;
        }

        public static string ObjectToJson(ConfigHandler config, object obj)
        {
            string json = null;
            //json = JsonConvert.DeserializeObject<string>(obj);
            //TODO naprawic

            return json;
        }

        public List<Audiobook> GetAllAudiobooks()
        {
            throw new NotImplementedException();
        }

        public Audiobook GetAudiobook()
        {
            throw new NotImplementedException();
        }

        public List<Audiobook> GetAudiobooks(string author, string title, string genre, string year, string language, string voiceType)
        {
            throw new NotImplementedException();
        }
    }
}
