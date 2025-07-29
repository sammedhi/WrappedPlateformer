using System;
using System.Collections.Generic;

namespace CircularPlatformer
{
    /// <summary>
    /// Simple Service Locator for managing global services.
    /// </summary>
    public static class ServiceLocator
    {
        /// <summary>
        /// Dictionary to hold registered services by their type.
        /// </summary>
        private static readonly Dictionary<Type, object> _services = new();

        /// <summary>
        /// Registers a service instance of type T.
        /// </summary>
        public static void Register<T>(T service)
        {
            _services[typeof(T)] = service;
        }

        /// <summary>
        /// Gets the registered service of type T.
        /// </summary>
        public static T Get<T>()
        {
            if (_services.TryGetValue(typeof(T), out var service))
            {
                return (T)service;
            }
            throw new Exception($"Service of type {typeof(T)} not registered.");
        }

        /// <summary>
        /// Unregisters the service of type T.
        /// </summary>
        public static void Unregister<T>()
        {
            _services.Remove(typeof(T));
        }

        /// <summary>
        /// Clears all registered services.
        /// </summary>
        public static void Clear()
        {
            _services.Clear();
        }
    }
}
