using UnityEngine;
using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Unit`. Inherits from `AtomVariable&lt;Unit, UnitPair, UnitEvent, UnitPairEvent, UnitUnitFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Unit", fileName = "UnitVariable")]
    public sealed class UnitVariable : AtomVariable<Unit, UnitPair, UnitEvent, UnitPairEvent, UnitUnitFunction>
    {
        protected override bool ValueEquals(Unit other)
        {
            return Value == other;
        }
    }
}
