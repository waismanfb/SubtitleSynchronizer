using Domain.Entities;
using System.Text.RegularExpressions;

namespace Application.Service.Subtitle
{
    /// <summary>
    /// SubtitleService is a class that represents the subtitle service.
    /// </summary>
    public class SubtitleService : ISubtitleService
    {
        /// <summary>
        /// ShiftSubtitles shifts the subtitles by the shift amount.
        /// </summary>
        /// <param name="subtitles">Subtitles</param>
        /// <param name="shiftAmount">Shift amouunt</param>
        /// <returns></returns>
        public List<SubtitleEntity> ShiftSubtitles(List<SubtitleEntity> subtitles, TimeSpan shiftAmount)
        {
            return subtitles.Select(subtitle =>
            {
                subtitle.StartTime += shiftAmount;
                subtitle.EndTime += shiftAmount;
                return subtitle;
            }).ToList();
        }

        /// <summary>
        /// LoadSubtitles loads the subtitles from the file path.
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns></returns>
        public List<SubtitleEntity> LoadSubtitles(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<SubtitleEntity> subtitles = new List<SubtitleEntity>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (Regex.IsMatch(lines[i], @"\d+:\d+:\d+,\d+ --> \d+:\d+:\d+,\d+"))
                {
                    SubtitleEntity subtitle = new SubtitleEntity
                    {
                        StartTime = ParseTime(lines[i].Split(" --> ")[0]),
                        EndTime = ParseTime(lines[i].Split(" --> ")[1]),
                        Text = lines[++i]
                    };

                    subtitles.Add(subtitle);
                }

            }

            return subtitles;
        }

        private TimeSpan ParseTime(string timeString)
        {
            return TimeSpan.ParseExact(timeString, "hh\\:mm\\:s\\,fff", null);
        }
    }
}
