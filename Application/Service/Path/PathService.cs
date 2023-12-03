using Domain.Entities;

namespace Application.Service.Path
{
    /// <summary>
    /// PathService is a class that represents the path service.
    /// </summary>
    public class PathService : IPathService
    {
        /// <summary>
        /// CalculatePaths calculates the paths between two nodes.
        /// </summary>
        /// <param name="paths">Paths</param>
        /// <param name="start">Start</param>
        /// <param name="end">End</param>
        /// <returns></returns>
        public List<string> CalculatePaths(List<PathEntity> paths, string start, string end)
        {
            return paths
                .Where(path => path.StartPoint == start && path.EndPoint == end)
                .Select(path => $"{path.StartPoint}-{path.EndPoint}")
                .ToList();
        }
    }
}
