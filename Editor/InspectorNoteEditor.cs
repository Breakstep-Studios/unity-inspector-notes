using BreakstepStudios.UnityInspectorNotes;
using UnityEditor;
using UnityEngine;

namespace BreakstepStudios.UnityInspectorNotes.Editor
{
    /// <summary>
    /// Draws the inspector UI for <see cref="InspectorNote"/>.
    /// </summary>
    [CustomEditor(typeof(InspectorNote))]
    public sealed class InspectorNoteEditor : UnityEditor.Editor
    {
        private SerializedProperty noteProperty;

        /// <summary>
        /// Draws the note field in the Unity Inspector.
        /// </summary>
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.LabelField("Note", EditorStyles.boldLabel);
            noteProperty.stringValue = EditorGUILayout.TextArea(noteProperty.stringValue, GUILayout.MinHeight(80f));

            serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Caches serialized properties used by the inspector.
        /// </summary>
        private void OnEnable()
        {
            noteProperty = serializedObject.FindProperty("note");
        }
    }
}
