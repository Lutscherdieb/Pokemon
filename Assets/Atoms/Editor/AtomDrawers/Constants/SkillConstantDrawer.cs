#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Skill`. Inherits from `AtomDrawer&lt;SkillConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SkillConstant))]
    public class SkillConstantDrawer : VariableDrawer<SkillConstant> { }
}
#endif
