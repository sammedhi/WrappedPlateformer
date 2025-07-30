using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Implementation of <see cref="IWorldCollider"/> for a world that 
    /// span a plan 
    /// </summary>
    public class PlanWorldCollider : IWorldCollider
    {
        /// <summary>
        /// The normal that define the plan
        /// </summary>
        private Vector3 _normal;

        /// <summary>
        /// The origin of the plan
        /// </summary>
        private Vector3 _origin;

        /// <summary>
        /// The error interval allowed to compute the collision
        /// </summary>
        private float _eps;

        public PlanWorldCollider(Vector3 normal, Vector3 origin)
        {
            _normal = normal;
            _origin = origin;
        }

        public Vector3? RayCollisionPoint(Ray ray)
        {
            var rayOriginToPlanOrigin = ray.origin - _origin;
            var a = Vector3.Dot(_normal, rayOriginToPlanOrigin);
            var b = Vector3.Dot(_normal, ray.direction);

            var collisionDistance = -a / b;
            if (collisionDistance < 0)
                return null;

            return ray.origin + ray.direction * collisionDistance;
        }
    }
}
