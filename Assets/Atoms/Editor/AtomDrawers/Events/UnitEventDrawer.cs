#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Unit`. Inherits from `AtomDrawer&lt;UnitEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitEvent))]
    public class UnitEventDrawer : AtomDrawer<UnitEvent> { }
}
#endif
