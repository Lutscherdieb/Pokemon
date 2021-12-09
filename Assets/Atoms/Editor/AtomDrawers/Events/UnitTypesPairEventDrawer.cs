#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnitTypesPair`. Inherits from `AtomDrawer&lt;UnitTypesPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitTypesPairEvent))]
    public class UnitTypesPairEventDrawer : AtomDrawer<UnitTypesPairEvent> { }
}
#endif
