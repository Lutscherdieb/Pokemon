#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `BuffPair`. Inherits from `AtomDrawer&lt;BuffPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BuffPairEvent))]
    public class BuffPairEventDrawer : AtomDrawer<BuffPairEvent> { }
}
#endif
