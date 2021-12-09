using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Sprite`. Inherits from `AtomReference&lt;Sprite, SpritePair, SpriteConstant, SpriteVariable, SpriteEvent, SpritePairEvent, SpriteSpriteFunction, SpriteVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpriteReference : AtomReference<
        Sprite,
        SpritePair,
        SpriteConstant,
        SpriteVariable,
        SpriteEvent,
        SpritePairEvent,
        SpriteSpriteFunction,
        SpriteVariableInstancer>, IEquatable<SpriteReference>
    {
        public SpriteReference() : base() { }
        public SpriteReference(Sprite value) : base(value) { }
        public bool Equals(SpriteReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Sprite other)
        {
            throw new NotImplementedException();
        }
    }
}
