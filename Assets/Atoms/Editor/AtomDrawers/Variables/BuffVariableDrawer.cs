#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Buff`. Inherits from `AtomDrawer&lt;BuffVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BuffVariable))]
    public class BuffVariableDrawer : VariableDrawer<BuffVariable> { }
}
#endif
