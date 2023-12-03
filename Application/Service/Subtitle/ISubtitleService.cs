using Domain.Entities;

namespace Application.Service.Subtitle
{
    /// <summary>
    /// ISubtitleService is an interface that represents the subtitle service.
    /// </summary>
    public interface ISubtitleService
    {
        /// <summary>
        /// ShiftSubtitles shifts the subtitles by the shift amount.
        /// </summary>
        /// <param name="subtitles">Subtitles</param>
        /// <param name="shiftAmount">Shift amount</param>
        /// <returns></returns>
        List<SubtitleEntity> ShiftSubtitles(List<SubtitleEntity> subtitles, TimeSpan shiftAmount);

        /// <summary>
        /// LoadSubtitles loads the subtitles from the file path.
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns></returns>
        List<SubtitleEntity> LoadSubtitles(string filePath);
    }
}
