using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// A component that move this gameobject to the tracked object
    /// position
    /// </summary>
    [RequireComponent(typeof(Tracker))]
    public class PositionTracker : MonoBehaviour
    {
        private Tracker _tracker;

        void Start()
        {
            _tracker = GetComponent<Tracker>();
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = _tracker.TrackedPosition;
        }
    }
}
