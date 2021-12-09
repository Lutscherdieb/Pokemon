#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Buff`. Inherits from `AtomDrawer&lt;BuffConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BuffConstant))]
    public class BuffConstantDrawer : VariableDrawer<BuffConstant> { }
}
#endif
