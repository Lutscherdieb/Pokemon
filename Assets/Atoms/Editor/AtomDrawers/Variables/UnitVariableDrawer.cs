#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Unit`. Inherits from `AtomDrawer&lt;UnitVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UnitVariable))]
    public class UnitVariableDrawer : VariableDrawer<UnitVariable> { }
}
#endif
