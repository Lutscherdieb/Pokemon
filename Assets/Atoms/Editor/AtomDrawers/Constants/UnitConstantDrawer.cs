#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Unit`. Inherits from `AtomDrawer&lt;UnitConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitConstant))]
    public class UnitConstantDrawer : VariableDrawer<UnitConstant> { }
}
#endif
