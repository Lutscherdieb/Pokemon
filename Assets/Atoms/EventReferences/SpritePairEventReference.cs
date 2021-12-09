using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SpritePair`. Inherits from `AtomEventReference&lt;SpritePair, SpriteVariable, SpritePairEvent, SpriteVariableInstancer, SpritePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpritePairEventReference : AtomEventReference<
        SpritePair,
        SpriteVariable,
        SpritePairEvent,
        SpriteVariableInstancer,
        SpritePairEventInstancer>, IGetEvent 
    { }
}
