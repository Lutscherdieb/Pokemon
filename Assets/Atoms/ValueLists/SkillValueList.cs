using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Skill`. Inherits from `AtomValueList&lt;Skill, SkillEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Skill", fileName = "SkillValueList")]
    public sealed class SkillValueList : AtomValueList<Skill, SkillEvent> { }
}
