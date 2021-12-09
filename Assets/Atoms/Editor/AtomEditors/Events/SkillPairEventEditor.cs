#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SkillPair`. Inherits from `AtomEventEditor&lt;SkillPair, SkillPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SkillPairEvent))]
    public sealed class SkillPairEventEditor : AtomEventEditor<SkillPair, SkillPairEvent> { }
}
#endif
