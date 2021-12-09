#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Unit`. Inherits from `AtomEventEditor&lt;Unit, UnitEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(UnitEvent))]
    public sealed class UnitEventEditor : AtomEventEditor<Unit, UnitEvent> { }
}
#endif
