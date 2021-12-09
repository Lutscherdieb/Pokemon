#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnitTypes`. Inherits from `AtomDrawer&lt;UnitTypesVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitTypesVariable))]
    public class UnitTypesVariableDrawer : VariableDrawer<UnitTypesVariable> { }
}
#endif
