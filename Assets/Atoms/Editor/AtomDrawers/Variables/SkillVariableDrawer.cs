#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Skill`. Inherits from `AtomDrawer&lt;SkillVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SkillVariable))]
    public class SkillVariableDrawer : VariableDrawer<SkillVariable> { }
}
#endif
