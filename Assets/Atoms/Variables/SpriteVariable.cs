using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Sprite`. Inherits from `AtomVariable&lt;Sprite, SpritePair, SpriteEvent, SpritePairEvent, SpriteSpriteFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Sprite", fileName = "SpriteVariable")]
    public sealed class SpriteVariable : AtomVariable<Sprite, SpritePair, SpriteEvent, SpritePairEvent, SpriteSpriteFunction>
    {
        protected override bool ValueEquals(Sprite other)
        {
            return Value == other;
        }
    }
}
