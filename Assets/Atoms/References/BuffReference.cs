using System;
using UnityAtoms.BaseAtoms;
using Lutscherdieb.Pokemon;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Buff`. Inherits from `AtomReference&lt;Buff, BuffPair, BuffConstant, BuffVariable, BuffEvent, BuffPairEvent, BuffBuffFunction, BuffVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BuffReference : AtomReference<
        Buff,
        BuffPair,
        BuffConstant,
        BuffVariable,
        BuffEvent,
        BuffPairEvent,
        BuffBuffFunction,
        BuffVariableInstancer>, IEquatable<BuffReference>
    {
        public BuffReference() : base() { }
        public BuffReference(Buff value) : base(value) { }
        public bool Equals(BuffReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Buff other)
        {
            throw new NotImplementedException();
        }
    }
}
