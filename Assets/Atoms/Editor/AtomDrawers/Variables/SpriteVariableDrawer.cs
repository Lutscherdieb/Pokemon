#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Sprite`. Inherits from `AtomDrawer&lt;SpriteVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpriteVariable))]
    public class SpriteVariableDrawer : VariableDrawer<SpriteVariable> { }
}
#endif
