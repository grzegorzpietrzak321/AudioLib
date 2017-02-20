using Newtonsoft.Json;

namespace AudioLib.Actions
{
    public static class JsonHandler
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
    }
}
