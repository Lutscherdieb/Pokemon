#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Buff`. Inherits from `AtomEventEditor&lt;Buff, BuffEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(BuffEvent))]
    public sealed class BuffEventEditor : AtomEventEditor<Buff, BuffEvent> { }
}
#endif
