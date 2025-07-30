using UnityEngine;

namespace CircularPlatformer
{

    /// <summary>
    /// A behaviour that will rotate the gameobject it's attached to so it points
    /// towards the tracker of index _trackerId
    /// </summary>
    [RequireComponent(typeof(Tracker))]
    class PointTowardTracker : MonoBehaviour
    {

        /// <summary>
        /// The direction toward which the object point initially
        /// </summary>
        [SerializeField] Vector3 originalPointDirection;

        private Tracker _trackerComponent;

        void Start()
        {
            _trackerComponent = GetComponent<Tracker>();
        }

        void Update()
        {
            var targetPosition = _trackerComponent.TrackedPosition;
            var rotation = Quaternion.identity;
            rotation.SetFromToRotation(originalPointDirection, targetPosition);
            transform.rotation = rotation;
            Debug.Log(targetPosition);
        }
    }
}