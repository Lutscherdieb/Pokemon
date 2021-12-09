using UnityEngine;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Skill`. Inherits from `SetVariableValue&lt;Skill, SkillPair, SkillVariable, SkillConstant, SkillReference, SkillEvent, SkillPairEvent, SkillVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Skill", fileName = "SetSkillVariableValue")]
    public sealed class SetSkillVariableValue : SetVariableValue<
        Skill,
        SkillPair,
        SkillVariable,
        SkillConstant,
        SkillReference,
        SkillEvent,
        SkillPairEvent,
        SkillSkillFunction,
        SkillVariableInstancer>
    { }
}
