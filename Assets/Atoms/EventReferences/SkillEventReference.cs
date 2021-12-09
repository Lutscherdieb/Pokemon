using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Skill`. Inherits from `AtomEventReference&lt;Skill, SkillVariable, SkillEvent, SkillVariableInstancer, SkillEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SkillEventReference : AtomEventReference<
        Skill,
        SkillVariable,
        SkillEvent,
        SkillVariableInstancer,
        SkillEventInstancer>, IGetEvent 
    { }
}
