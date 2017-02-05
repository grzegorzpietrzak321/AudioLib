namespace AudioLib.Model
{
    public class Audiobook
    {
        public int AudiobookId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Storyline { get; set; }
        public int PartOfStoryline { get; set; }
        public int PubishDateBook { get; set; }
        public int PublishDateAudiobook { get; set; }
        public enum VoiceType
        {
            Sluchowisko,
            ProLektor,
            AmaLektor,
            Synt
        }
        public BookPublisher BookPublishers { get; set; }
        public string FolderLocation { get; set; } //path in library
        public string CoverLocation { get; set; } //path in library
        public int Rank { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual string FilesList { get; set; } //path in library

        public Audiobook(string title, string locat)
        {
            Title = title;
            FolderLocation = locat;
        }

        public Audiobook()
        {

        }
    }
}
