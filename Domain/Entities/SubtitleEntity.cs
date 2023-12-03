namespace Domain.Entities
{
    /// <summary>
    /// SubtitleEntity is a class that represents a subtitle.
    /// </summary>
    public class SubtitleEntity
    {
        /// <summary>
        /// StartTime is the starting time of the subtitle.
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// EndTime is the ending time of the subtitle.
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Text is the text of the subtitle.
        /// </summary>
        public string? Text { get; set; }
    }
}
