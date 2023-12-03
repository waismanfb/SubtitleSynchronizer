using Domain.Entities;
using Xunit;

namespace Application.Service.Subtitle.Tests
{
    /// <summary>
    /// SubtitleServiceTests is a class that represents the subtitle service tests.
    /// </summary>
    public class SubtitleServiceTests
    {
        private readonly SubtitleService _subtitleService;

        /// <summary>
        /// SubtitleServiceTests constructor.
        /// </summary>
        public SubtitleServiceTests()
        {
            _subtitleService = new SubtitleService();
        }

        /// <summary>
        /// Valid subtitle file path.
        /// </summary>
        [Fact]
        public void ShiftSubtitles_ShouldShiftSubtitlesByGivenAmount()
        {
            // Arrange
            List<SubtitleEntity> subtitles = _subtitleService.LoadSubtitles("../../../Application/Service/The.Matrix.1999.BluRay.720p.Malay.srt");
            TimeSpan shiftAmount = TimeSpan.FromSeconds(1);

            // Act
            var result = _subtitleService.ShiftSubtitles(subtitles, shiftAmount);

            // Assert
            Assert.True(AreSubtitlesOrdered(result));
        }

        private bool AreSubtitlesOrdered(List<SubtitleEntity> subtitles)
        {
            for (int i = 1; i < subtitles.Count; i++)
            {
                if (subtitles[i].StartTime < subtitles[i - 1].EndTime)
                    return false;
            }

            return true;
        }
    }
}
