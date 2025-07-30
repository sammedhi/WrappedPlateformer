using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;

namespace CircularPlatformer
{
    /// <summary>
    /// Fetch a tracker object of id _trackerId and provides accessibility for
    /// other behaviours on the gameobject
    /// </summary>
    class Tracker : MonoBehaviour
    {
        /// <summary>
        /// The id of the tracker to follow
        /// </summary>
        [SerializeField] int _trackerId;

        /// <summary>
        /// The tracker that this component is following
        /// </summary>
        private ITracker _tracker;

        /// <summary>
        /// Provide the position of the tracked object
        /// </summary>
        public Vector3 TrackedPosition => _tracker.GetTrackedPosition();

        void Start()
        {
            var trackerProvider = ServiceLocator.Get<TrackerProvider>();
            var trackers = trackerProvider.GetTrackers().ToList();
            Assert.IsTrue(_trackerId < trackers.Count, $"There is no ITracker registered with id {_trackerId}");
            _tracker = trackers[_trackerId];
        }

    }
}