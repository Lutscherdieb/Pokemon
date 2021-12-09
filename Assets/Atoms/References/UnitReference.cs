using System;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Unit`. Inherits from `AtomReference&lt;Unit, UnitPair, UnitConstant, UnitVariable, UnitEvent, UnitPairEvent, UnitUnitFunction, UnitVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UnitReference : AtomReference<
        Unit,
        UnitPair,
        UnitConstant,
        UnitVariable,
        UnitEvent,
        UnitPairEvent,
        UnitUnitFunction,
        UnitVariableInstancer>, IEquatable<UnitReference>
    {
        public UnitReference() : base() { }
        public UnitReference(Unit value) : base(value) { }
        public bool Equals(UnitReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Unit other)
        {
            throw new NotImplementedException();
        }
    }
}
