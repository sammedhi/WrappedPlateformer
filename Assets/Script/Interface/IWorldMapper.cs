using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Interface for mapping a point from the current world space to the original space.
    /// </summary>
    public interface IWorldMapper
    {
        /// <summary>
        /// Converts a position from the current world space to the original space.
        /// </summary>
        /// <param name="position">The position in the current world space.</param>
        /// <returns>The position in the original space.</returns>
        Vector3 ConvertPoint(Vector3 position);
    }
}
