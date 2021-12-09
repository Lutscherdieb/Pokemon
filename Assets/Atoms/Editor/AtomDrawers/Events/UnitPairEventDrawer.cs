#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnitPair`. Inherits from `AtomDrawer&lt;UnitPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitPairEvent))]
    public class UnitPairEventDrawer : AtomDrawer<UnitPairEvent> { }
}
#endif
