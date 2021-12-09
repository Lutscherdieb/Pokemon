#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Sprite`. Inherits from `AtomDrawer&lt;SpriteValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteValueList))]
    public class SpriteValueListDrawer : AtomDrawer<SpriteValueList> { }
}
#endif
