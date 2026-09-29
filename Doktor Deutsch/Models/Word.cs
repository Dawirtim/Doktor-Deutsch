namespace Doktor_Deutsch.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string German { get; set; }
        public string Polish { get; set; }
        public string? Example { get; set; }
        public string? ExampleTranslation { get; set; }
        public string? Category { get; set; }
        public string? RecordingFile { get; set; }
        public DateTime RetakeDate { get; set; }
    }
}
