#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpritePair`. Inherits from `AtomDrawer&lt;SpritePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpritePairEvent))]
    public class SpritePairEventDrawer : AtomDrawer<SpritePairEvent> { }
}
#endif
