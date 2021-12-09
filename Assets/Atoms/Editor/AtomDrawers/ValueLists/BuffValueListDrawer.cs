#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Buff`. Inherits from `AtomDrawer&lt;BuffValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BuffValueList))]
    public class BuffValueListDrawer : AtomDrawer<BuffValueList> { }
}
#endif
