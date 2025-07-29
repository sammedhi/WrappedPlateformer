using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Interface to manage collision with a given map
    /// </summary>
    public interface IWorldCollider
    {
        /// <summary>
        /// Compute where the ray collide with the given map.
        /// </summary>
        /// <param name="ray">The input ray.</param>
        /// <returns>The collision point as a Vector3, or null if no collision.</returns>
        Vector3? RayCollisionPoint(Ray ray);
    }
}
