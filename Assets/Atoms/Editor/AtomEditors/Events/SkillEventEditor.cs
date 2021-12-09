#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using Lutscherdieb.Pokemon;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Skill`. Inherits from `AtomEventEditor&lt;Skill, SkillEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SkillEvent))]
    public sealed class SkillEventEditor : AtomEventEditor<Skill, SkillEvent> { }
}
#endif
