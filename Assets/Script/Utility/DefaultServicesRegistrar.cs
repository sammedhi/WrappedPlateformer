using UnityEngine;

namespace CircularPlatformer
{
    /// <summary>
    /// Registrar that will instantiate and register in the service locator
    /// the services used in the default scenario.
    /// </summary>
    [DefaultExecutionOrder(-10000)]
    public class DefaultServicesRegistrar : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Awake()
        {
            ServiceLocator.Register(new TrackerProvider());
        }
    }
}
