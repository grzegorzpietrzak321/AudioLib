using AudioLib.Model;
using System.Collections.Generic;

namespace AudioLib.Actions
{
    class SQLHandler : IDatabaseActions
    {
        public List<Audiobook> GetAllAudiobooks()
        {
            throw new System.NotImplementedException();
        }

        public Audiobook GetAudiobook()
        {
            throw new System.NotImplementedException();
        }

        public List<Audiobook> GetAudiobooks(string author, string title, string genre, string year, string language, string voiceType,
            string rank)
        {
            throw new System.NotImplementedException();
        }
    }
}
