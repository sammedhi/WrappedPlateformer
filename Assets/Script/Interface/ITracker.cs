using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Provides a 3D position being targeted by some devices, AI or system.
    /// </summary>
    public interface ITracker
    {
        Vector3 GetTrackedPosition();
    }
}
