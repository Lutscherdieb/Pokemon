#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SkillPair`. Inherits from `AtomDrawer&lt;SkillPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SkillPairEvent))]
    public class SkillPairEventDrawer : AtomDrawer<SkillPairEvent> { }
}
#endif
