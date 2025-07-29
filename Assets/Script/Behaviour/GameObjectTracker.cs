using UnityEngine;
using UnityEngine.Assertions;

namespace CircularPlatformer
{
    /// <summary>
    /// Tracks the position of the gameobject this behaviour is attached to in 3D space.
    /// </summary>
    public class GameObjectTracker : MonoBehaviour, ITracker
    {
        private TrackerProvider _trackerProvider;

        private void Awake()
        {
            _trackerProvider = ServiceLocator.Get<TrackerProvider>();

            Assert.IsNotNull(_trackerProvider, "There is no tracker provider to register to");
        }

        void OnEnable()
        {
            _trackerProvider.Register(this);
        }

        void OnDisable()
        {
            _trackerProvider.Unregister(this);
        }

        public Vector3 GetTrackedPosition()
        {
            return transform.position;
        }
    }
}
