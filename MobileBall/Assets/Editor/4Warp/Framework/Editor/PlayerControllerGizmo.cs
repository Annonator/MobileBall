using UnityEditor;

using UnityEngine;

using _4Warp.Framework.Controlls;

namespace _4Warp.Framework.Editor
{
    [CustomEditor(typeof(PlayerController))]
    public class PlayerControllerGizmo : UnityEditor.Editor
    {
        public static bool VisualizeDirection;

        [DrawGizmo(GizmoType.NonSelected | GizmoType.Selected)]
        public static void DrawGizmoForPlayerController(PlayerController player, GizmoType gizmoType)
        {
            if (!VisualizeDirection)
            {
                return;
            }

            var position = player.transform.position;
            var playerPosition = player.GetComponent<PlayerController>();

            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(position, playerPosition.Direction.normalized);
        }

        public override void OnInspectorGUI()
        {
            this.DrawDefaultInspector();
            VisualizeDirection = EditorGUILayout.Toggle("Toggle Direction", VisualizeDirection);
        }
    }
}