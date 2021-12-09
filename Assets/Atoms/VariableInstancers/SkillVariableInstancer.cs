using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Skill`. Inherits from `AtomVariableInstancer&lt;SkillVariable, SkillPair, Skill, SkillEvent, SkillPairEvent, SkillSkillFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Skill Variable Instancer")]
    public class SkillVariableInstancer : AtomVariableInstancer<
        SkillVariable,
        SkillPair,
        Skill,
        SkillEvent,
        SkillPairEvent,
        SkillSkillFunction>
    { }
}
