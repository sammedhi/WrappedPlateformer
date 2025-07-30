using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Represents a gun in the game. It can shoot bullet in a given direction
    /// </summary>
    public class Gun : MonoBehaviour
    {
        /// <summary>
        /// The number of bullet shooted per seconds
        /// </summary>
        [SerializeField] float _shootRate = 1f;

        /// <summary>
        /// Bullets spawned by the gun
        /// </summary>
        [SerializeField] Bullet _bullet;

        /// <summary>
        /// The position where bullets are spawned
        /// </summary>
        [SerializeField] Transform _bulletSpawnPosition;

        /// <summary>
        /// Give you the time that elapsed between bullets
        /// </summary>
        public float DelayBetweenShoot => 1f / _shootRate;

        /// <summary>
        /// The remaining time before the gun can shoot the next bullet
        /// </summary>
        private float _remainingRefreshDelay = 0f;

        /// <summary>
        /// Whether the gun is shooting
        /// </summary>
        private bool _isShooting = false;

        /// <summary>
        /// The position targeted by the gun
        /// </summary>
        private Vector3 _targetDirection;

        void Update()
        {
            _remainingRefreshDelay -= Time.deltaTime;
            if (!_isShooting) return;

            _isShooting = false;

            if (_remainingRefreshDelay > 0f) return;

            _remainingRefreshDelay = DelayBetweenShoot;

            if (_bullet == null)
            {
                Debug.LogError("There are no bullet Prefab attached to the gun, it cannot shoot");
                return;
            }

            var bullet = Instantiate(_bullet);
            bullet.transform.position = _bulletSpawnPosition.position;
            bullet.Direction = _targetDirection;
        }

        public void Shoot(Vector3 targetDirection)
        {
            _isShooting = true;
            _targetDirection = targetDirection;
        }
    }
}
