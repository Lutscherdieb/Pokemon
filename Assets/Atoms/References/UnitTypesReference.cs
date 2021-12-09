using System;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `UnitTypes`. Inherits from `AtomReference&lt;UnitTypes, UnitTypesPair, UnitTypesConstant, UnitTypesVariable, UnitTypesEvent, UnitTypesPairEvent, UnitTypesUnitTypesFunction, UnitTypesVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitTypesReference : AtomReference<
        UnitTypes,
        UnitTypesPair,
        UnitTypesConstant,
        UnitTypesVariable,
        UnitTypesEvent,
        UnitTypesPairEvent,
        UnitTypesUnitTypesFunction,
        UnitTypesVariableInstancer>, IEquatable<UnitTypesReference>
    {
        public UnitTypesReference() : base() { }
        public UnitTypesReference(UnitTypes value) : base(value) { }
        public bool Equals(UnitTypesReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnitTypes other)
        {
            throw new NotImplementedException();
        }
    }
}
