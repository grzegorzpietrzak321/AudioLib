namespace AudioLib.Actions
{
    public class ConfigHandler
    {
        public string ConfigFileLocation { get; set; }
        public string LibraryLocation { get; set; }
        public string LibrabyLocationOnDevice { get; set; }



        public void ReadConfigFromFile(string fileConfigAddress)
        {

        }

        public void SaveConfigToFile(ConfigHandler _config, string LibraryLocation)
        {
            JsonHandler.ObjectToJson(_config, LibraryLocation);
        }
    }
}