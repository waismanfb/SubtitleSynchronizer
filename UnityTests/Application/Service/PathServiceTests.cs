using Domain.Entities;
using Xunit;

namespace Application.Service.Path.Tests
{
    /// <summary>
    /// PathServiceTests` is a class that represents the path service tests.
    /// </summary>
    public class PathServiceTests
    {
        private readonly PathService _pathService;

        /// <summary>
        /// PathServiceTests constructor.
        /// </summary>
        public PathServiceTests()
        {
            _pathService = new PathService();
        }

        [Fact]
        public void CalculatePaths_ShouldReturnCorrectPaths()
        {
            // Arrange
            List<PathEntity> paths = new List<PathEntity>
            {
                new PathEntity("A", "B"),
                new PathEntity("B", "C"),
                new PathEntity("A", "C"),
            };

            string start = "A";
            string end = "C";

            // Act
            List<string> result = _pathService.CalculatePaths(paths, start, end);

            // Assert
            Assert.Contains("A-C", result);
            Assert.DoesNotContain("A-B", result);
            Assert.DoesNotContain("B-C", result);
        }
    }
}
