#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnitTypes`. Inherits from `AtomEventEditor&lt;UnitTypes, UnitTypesEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(UnitTypesEvent))]
    public sealed class UnitTypesEventEditor : AtomEventEditor<UnitTypes, UnitTypesEvent> { }
}
#endif
