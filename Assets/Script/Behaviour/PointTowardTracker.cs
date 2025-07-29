using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;

namespace CircularPlatformer
{
    /// <summary>
    /// A behaviour that will rotate the gameobject it's attached to so it points
    /// towards the tracker of index _trackerId
    /// </summary>
    class PointTowardTracker : MonoBehaviour
    {
        /// <summary>
        /// The id of the tracker to follow
        /// </summary>
        [SerializeField] int _trackerId;

        /// <summary>
        /// The direction toward which the object point initially
        /// </summary>
        [SerializeField] Vector3 originalPointDirection;

        private ITracker _tracker;

        void Start()
        {
            var trackerProvider = ServiceLocator.Get<TrackerProvider>();
            var trackers = trackerProvider.GetTrackers().ToList();
            Assert.IsTrue(_trackerId < trackers.Count, $"There is no ITracker registered with id {_trackerId}");
            _tracker = trackers[_trackerId];
        }

        void Update()
        {
            var targetPosition = _tracker.GetTrackedPosition();
            var rotation = Quaternion.identity;
            rotation.SetFromToRotation(originalPointDirection, targetPosition);
            transform.rotation = rotation;
            Debug.Log(targetPosition);
        }
    }
}