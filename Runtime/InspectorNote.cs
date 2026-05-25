using UnityEngine;

namespace BreakstepStudios.UnityInspectorNotes
{
    /// <summary>
    /// Stores a note on a GameObject so project context can live next to the object it describes.
    /// </summary>
    [AddComponentMenu("Breakstep Studios/Inspector Note")]
    public sealed class InspectorNote : MonoBehaviour
    {
        [SerializeField]
        [TextArea(3, 12)]
        private string note = string.Empty;

        /// <summary>
        /// Gets or sets the note text attached to this GameObject.
        /// </summary>
        public string Note
        {
            get => note;
            set => note = value;
        }
    }
}
