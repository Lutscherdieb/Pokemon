#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnitPair`. Inherits from `AtomEventEditor&lt;UnitPair, UnitPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(UnitPairEvent))]
    public sealed class UnitPairEventEditor : AtomEventEditor<UnitPair, UnitPairEvent> { }
}
#endif
