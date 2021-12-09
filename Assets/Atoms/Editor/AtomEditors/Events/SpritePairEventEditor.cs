#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpritePair`. Inherits from `AtomEventEditor&lt;SpritePair, SpritePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpritePairEvent))]
    public sealed class SpritePairEventEditor : AtomEventEditor<SpritePair, SpritePairEvent> { }
}
#endif
