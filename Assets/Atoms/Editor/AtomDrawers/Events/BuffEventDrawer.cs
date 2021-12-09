#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Buff`. Inherits from `AtomDrawer&lt;BuffEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BuffEvent))]
    public class BuffEventDrawer : AtomDrawer<BuffEvent> { }
}
#endif
