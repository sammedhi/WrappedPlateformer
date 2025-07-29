using System.Collections.Generic;
using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// System to register the active <see cref="ITracker"/>, it's the gateway
    /// for other system to find ITracker  
    /// </summary>
    public class TrackerProvider
    {
        /// <summary>
        /// The list of registered trackers
        /// </summary>
        readonly List<ITracker> _trackers;

        /// <summary>
        /// Registers a new tracker.
        /// </summary>
        /// <param name="tracker">The tracker to register</param>
        public void Register(ITracker tracker)
        {
            _trackers.Add(tracker);
            Debug.Log("Tracker registered: " + tracker);
        }

        /// <summary>
        /// Unregisters an existing tracker.
        /// </summary>
        /// <param name="tracker">The tracker to unregister</param>
        public void Unregister(ITracker tracker)
        {
            if (_trackers.Remove(tracker))
            {
                Debug.Log("Tracker unregistered: " + tracker);
            }
            else
            {
                Debug.LogWarning("Tracker not found for unregistration: " + tracker);
            }
        }

        /// <summary>
        /// Gets all registered trackers.
        /// </summary>
        /// <returns>All registered trackers.</returns>
        public IEnumerable<ITracker> GetTrackers() => _trackers;
    }
}
