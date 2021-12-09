using UnityEngine;
using System;
using Lutscherdieb.Pokemon;

namespace UnityAtoms{
    /// <summary>
    /// Variable of type `UnitTypes`. Inherits from `AtomVariable&lt;UnitTypes, UnitTypesPair, UnitTypesEvent, UnitTypesPairEvent, UnitTypesUnitTypesFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/UnitTypes", fileName = "UnitTypesVariable")]
    public sealed class UnitTypesVariable : AtomVariable<UnitTypes, UnitTypesPair, UnitTypesEvent, UnitTypesPairEvent, UnitTypesUnitTypesFunction>{
        protected override bool ValueEquals(UnitTypes other){
            return Value == other;
        }
    }
}
