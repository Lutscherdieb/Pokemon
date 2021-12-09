using UnityEngine;
using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Buff`. Inherits from `AtomVariable&lt;Buff, BuffPair, BuffEvent, BuffPairEvent, BuffBuffFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Buff", fileName = "BuffVariable")]
    public sealed class BuffVariable : AtomVariable<Buff, BuffPair, BuffEvent, BuffPairEvent, BuffBuffFunction>
    {
        protected override bool ValueEquals(Buff other)
        {
            return Value == other;
        }
    }
}
