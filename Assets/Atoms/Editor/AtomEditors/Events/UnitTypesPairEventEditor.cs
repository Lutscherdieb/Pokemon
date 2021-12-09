#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnitTypesPair`. Inherits from `AtomEventEditor&lt;UnitTypesPair, UnitTypesPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(UnitTypesPairEvent))]
    public sealed class UnitTypesPairEventEditor : AtomEventEditor<UnitTypesPair, UnitTypesPairEvent> { }
}
#endif
