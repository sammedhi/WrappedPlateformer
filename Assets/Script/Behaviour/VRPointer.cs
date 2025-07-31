using UnityEngine;

namespace CircularPlatformer
{
    public class VRPointer : MonoBehaviour
    {
        [SerializeField] string actionMapName;

        private VrPointerControllerTracker _controllerTracker;

        void OnEnable()
        {
            _controllerTracker = new VrPointerControllerTracker(actionMapName);
        }

        void OnDisable()
        {
            _controllerTracker.Dispose();
        }
    }
}