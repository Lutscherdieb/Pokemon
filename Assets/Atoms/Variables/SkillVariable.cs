using UnityEngine;
using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Skill`. Inherits from `AtomVariable&lt;Skill, SkillPair, SkillEvent, SkillPairEvent, SkillSkillFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Skill", fileName = "SkillVariable")]
    public sealed class SkillVariable : AtomVariable<Skill, SkillPair, SkillEvent, SkillPairEvent, SkillSkillFunction>
    {
        protected override bool ValueEquals(Skill other)
        {
            return Value == other;
        }
    }
}
