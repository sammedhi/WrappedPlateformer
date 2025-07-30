using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// A bullet that have an initial force and get propelled using physics
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class ForceBasedBullet : Bullet
    {
        [SerializeField] float _initialForce;

        private void Start()
        {
            var rb = GetComponent<Rigidbody>();
            rb.AddForce(_initialForce * Direction.normalized);
        }
    }
}
