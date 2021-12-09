#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `BuffPair`. Inherits from `AtomEventEditor&lt;BuffPair, BuffPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(BuffPairEvent))]
    public sealed class BuffPairEventEditor : AtomEventEditor<BuffPair, BuffPairEvent> { }
}
#endif
