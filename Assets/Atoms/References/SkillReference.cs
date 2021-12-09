using System;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Skill`. Inherits from `AtomReference&lt;Skill, SkillPair, SkillConstant, SkillVariable, SkillEvent, SkillPairEvent, SkillSkillFunction, SkillVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SkillReference : AtomReference<
        Skill,
        SkillPair,
        SkillConstant,
        SkillVariable,
        SkillEvent,
        SkillPairEvent,
        SkillSkillFunction,
        SkillVariableInstancer>, IEquatable<SkillReference>
    {
        public SkillReference() : base() { }
        public SkillReference(Skill value) : base(value) { }
        public bool Equals(SkillReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Skill other)
        {
            throw new NotImplementedException();
        }
    }
}
