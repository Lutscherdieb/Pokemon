#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UnitTypes`. Inherits from `AtomDrawer&lt;UnitTypesConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitTypesConstant))]
    public class UnitTypesConstantDrawer : VariableDrawer<UnitTypesConstant> { }
}
#endif
