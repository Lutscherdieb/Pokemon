#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnitTypes`. Inherits from `AtomDrawer&lt;UnitTypesValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitTypesValueList))]
    public class UnitTypesValueListDrawer : AtomDrawer<UnitTypesValueList> { }
}
#endif
