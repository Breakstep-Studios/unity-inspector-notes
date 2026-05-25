using BreakstepStudios.UnityInspectorNotes;
using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace BreakstepStudios.UnityInspectorNotes.Editor
{
    /// <summary>
    /// Draws the inspector UI for <see cref="InspectorNote"/>.
    /// </summary>
    [CustomEditor(typeof(InspectorNote))]
    public sealed class InspectorNoteEditor : UnityEditor.Editor
    {
        private const string NotePropertyName = "note";
        private const float MinimumNoteHeight = 80f;

        /// <summary>
        /// Creates the note inspector using UI Toolkit.
        /// </summary>
        /// <returns>The root visual element for the inspector.</returns>
        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement();
            root.style.flexGrow = 1f;

            Label noteLabel = new Label("Note");
            noteLabel.style.unityFontStyleAndWeight = FontStyle.Bold;

            TextField noteField = new TextField
            {
                bindingPath = NotePropertyName,
                multiline = true
            };
            noteField.style.minHeight = MinimumNoteHeight;
            noteField.style.flexGrow = 1f;
            noteField.style.whiteSpace = WhiteSpace.Normal;

            root.Add(noteLabel);
            root.Add(noteField);
            root.Bind(serializedObject);

            return root;
        }
    }
}
