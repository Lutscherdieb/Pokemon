#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Sprite`. Inherits from `AtomDrawer&lt;SpriteEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteEvent))]
    public class SpriteEventDrawer : AtomDrawer<SpriteEvent> { }
}
#endif
