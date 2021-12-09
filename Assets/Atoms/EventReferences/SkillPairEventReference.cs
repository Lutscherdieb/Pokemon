using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SkillPair`. Inherits from `AtomEventReference&lt;SkillPair, SkillVariable, SkillPairEvent, SkillVariableInstancer, SkillPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SkillPairEventReference : AtomEventReference<
        SkillPair,
        SkillVariable,
        SkillPairEvent,
        SkillVariableInstancer,
        SkillPairEventInstancer>, IGetEvent 
    { }
}
