#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Unit`. Inherits from `AtomDrawer&lt;UnitValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitValueList))]
    public class UnitValueListDrawer : AtomDrawer<UnitValueList> { }
}
#endif
