using UnityEditor;
using UnityEngine;
using WrapShader;

namespace CircularPlatformer.Editor
{
    /// <summary>
    /// Editor window that provides utilities to control the wrapping shaders
    /// </summary>
    class WrappingControllerWindow : EditorWindow
    {
        /// <summary>
        /// Is world wrapping enabled
        /// </summary>
        [SerializeField] bool _wrappingEnabled;

        [MenuItem("Window/Wrapping Controller Window")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(WrappingControllerWindow), true);
        }

        void OnGUI()
        {
            if (GUILayout.Toggle(_wrappingEnabled, "Enable Wrapping"))
            {
                if (!_wrappingEnabled) SceneView.RepaintAll();

                _wrappingEnabled = true;
                WrappingController.EnableWrapping();
            }
            else
            {
                if (!_wrappingEnabled) SceneView.RepaintAll();

                _wrappingEnabled = false;
                WrappingController.DisableWrapping();
            }
        }
    }
}