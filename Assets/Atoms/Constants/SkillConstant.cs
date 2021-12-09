using UnityEngine;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Constant of type `Skill`. Inherits from `AtomBaseVariable&lt;Skill&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Skill", fileName = "SkillConstant")]
    public sealed class SkillConstant : AtomBaseVariable<Skill> { }
}
