using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Tracks the position of a GameObject in 3D space.
    /// </summary>
    public class GameObjectTracker : MonoBehaviour, ITracker
    {
        public Vector3 GetTrackedPosition()
        {
            return transform.position;
        }
    }
}
