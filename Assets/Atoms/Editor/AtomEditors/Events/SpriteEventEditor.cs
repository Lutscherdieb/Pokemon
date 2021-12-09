#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Sprite`. Inherits from `AtomEventEditor&lt;Sprite, SpriteEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpriteEvent))]
    public sealed class SpriteEventEditor : AtomEventEditor<Sprite, SpriteEvent> { }
}
#endif
