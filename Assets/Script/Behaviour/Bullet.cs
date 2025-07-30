using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Represents a bullet in the game. 
    /// It is typically spawned by a gun and moves in a specified direction.
    /// </summary>
    public abstract class Bullet : MonoBehaviour
    {
        /// <summary>
        /// The direction to which the bullet will fly away
        /// </summary>
        public Vector3 Direction { get; set; }
    }
}
