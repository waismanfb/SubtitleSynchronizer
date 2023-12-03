using Domain.Entities;

namespace Application.Service.Path
{
    /// <summary>
    /// IPathService is an interface that represents the path service.
    /// </summary>
    public interface IPathService
    {
        /// <summary>
        /// CalculatePaths calculates the paths between two nodes.
        /// </summary>
        /// <param name="paths">Paths</param>
        /// <param name="start">Start</param>
        /// <param name="end">End</param>
        /// <returns></returns>
        List<string> CalculatePaths(List<PathEntity> paths, string start, string end);
    }
}
