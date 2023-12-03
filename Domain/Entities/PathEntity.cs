namespace Domain.Entities
{
    /// <summary>
    /// PathEntity is a class that represents a path between two points.
    /// </summary>
    public class PathEntity
    {
        /// <summary>
        /// StartPoint is the starting point of the path.
        /// </summary>
        public string StartPoint { get; set; }

        /// <summary>
        /// EndPoint is the ending point of the path.
        /// </summary>
        public string EndPoint { get; set; }

        /// <summary>
        /// PathEntity is a constructor that creates a new instance of the PathEntity class.
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        public PathEntity(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}
