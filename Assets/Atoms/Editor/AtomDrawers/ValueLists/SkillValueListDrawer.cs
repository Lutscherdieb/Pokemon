#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Skill`. Inherits from `AtomDrawer&lt;SkillValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SkillValueList))]
    public class SkillValueListDrawer : AtomDrawer<SkillValueList> { }
}
#endif
