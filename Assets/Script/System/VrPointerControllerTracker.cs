using UnityEngine;
using UnityEngine.InputSystem;

namespace CircularPlatformer
{
    /// <summary>
    /// Implement the <see cref="ControllerTracker"/> abstract class for a VR pointer
    /// controller
    /// </summary>
    public class VrPointerControllerTracker : ControllerTracker
    {
        private readonly InputAction _controllerPositionAction;

        private readonly InputAction _controllerRotationAction;

        public VrPointerControllerTracker(string actionMapName) : base()
        {
            _controllerPositionAction = InputSystem.actions.FindActionMap(actionMapName).FindAction("Position");
            _controllerRotationAction = InputSystem.actions.FindActionMap(actionMapName).FindAction("Rotation");
        }

        protected override Ray GetTargetRay()
        {
            return new Ray
            {
                origin = _controllerPositionAction.ReadValue<Vector3>(),
                direction = _controllerRotationAction.ReadValue<Quaternion>() * Vector3.forward,
            };
        }
    }
}
