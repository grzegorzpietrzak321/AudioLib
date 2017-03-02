using AudioLib.Model;
using System.Collections.Generic;

namespace AudioLib.Actions
{
    interface IDatabaseActions
    {
        List<Audiobook> GetAllAudiobooks();
        Audiobook GetAudiobook();
        List<Audiobook> GetAudiobooks(string author, string title, string genre, string year, string language, string voiceType, string rank);

    }
}
