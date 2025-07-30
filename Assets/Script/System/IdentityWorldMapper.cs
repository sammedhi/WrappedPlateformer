using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Implement the <see cref="IWorldMapper"/> when there are no transformation
    /// </summary>
    public class IdentityWorldMapper : IWorldMapper
    {
        public Vector3 ConvertPoint(Vector3 position)
        {
            return position;
        }
    }
}
